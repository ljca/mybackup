const menusInTabs = {};

const asyncContextMenuCreation = (tabId, settings) => {
    return new Promise((resolve, reject) => {
        try {
            chrome.contextMenus.create(
                settings, () => {
                    if (chrome.runtime.lastError)
                        reject(chrome.runtime.lastError);
                    else {
                        resolve();
                    }
                });
        } catch (e) {
            reject(chrome.runtime.lastError);
        }
    });
};

const clearContextMenusForTab = (tabId) => {
    if (menusInTabs[tabId] && menusInTabs[tabId].length > 0) {
        async.map(menusInTabs[tabId],
            (id, next) => {
                chrome.contextMenus.remove(id, next);
            }, () => {
                delete menusInTabs[tabId];
            });
    }
};

chrome.tabs.onUpdated.addListener(function (tabId, info, tab) {
    if (info.status === "loading") {
        clearContextMenusForTab(tabId);
    }
});

chrome.tabs.onRemoved.addListener(function (tabId) {
    clearContextMenusForTab(tabId);
});

const setContextMenuForSerp = async (request, sender, callback) => {

    const tabId = sender.tab.id;
    const parentId = tabId + "_stylishMenu_" + request.href + "_" + request.position;
    if (!menusInTabs[tabId])
        menusInTabs[tabId] = [];

    try {

        await asyncContextMenuCreation(tabId, {
            title: chrome.i18n.getMessage("themesByStylish"),
            id: parentId,
            targetUrlPatterns: [request.href],
            contexts: ["link"],
            documentUrlPatterns: ["*://" + request.host + "/*"]
        });

        menusInTabs[tabId].push(parentId);

        if (!request.styles) {
            await asyncContextMenuCreation(tabId, {
                title: chrome.i18n.getMessage("noThemesAvailable"),
                id: parentId + "_" + "no_styles",
                type: "normal",
                contexts: ["link"],
                parentId: parentId,
                enabled: false,
                onclick: () => {
                }
            });
        } else {

            const parsedLink = tldjs.parse(request.href);
            const link = document.createElement('a');
            link.href = request.href;

            await Promise.all(request.styles.map(style => {
                return asyncContextMenuCreation(tabId, {
                    title: style.stylename,
                    id: parentId + "_" + style.styleid,
                    type: "normal",
                    contexts: ["link"],
                    parentId: parentId,
                    onclick: () => {
                        analyticsEvent('SERP', 'Theme clicked', style.style_url);
                        chrome.tabs.create({url: style.style_url + "?utm_source=serp"});
                    }
                });
            }));

            if (request.showMore) {

                await asyncContextMenuCreation(tabId, {
                    id: parentId + "_more_separator",
                    type: "separator",
                    contexts: ["link"],
                    parentId: parentId,
                    onclick: () => {
                    }
                });

                const linkToUse = (parsedLink.domain.replace("." + parsedLink.publicSuffix, '') || link.host.replace(/^https?\:\/\//, '').replace('www.', ''));

                await asyncContextMenuCreation(tabId, {
                    title: chrome.i18n.getMessage("viewMore"),
                    id: parentId + "_more",
                    type: "normal",
                    contexts: ["link"],
                    parentId: parentId,
                    onclick: () => {
                        analyticsEvent('SERP', 'View More clicked');
                        chrome.tabs.create({url: 'https://userstyles.org/styles/browse/' + linkToUse + "?utm_source=serp"});
                    }
                });
            }

        }

        callback();

    } catch (e) {
        //console.error(e);
    }
};