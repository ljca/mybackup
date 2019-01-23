
// 0 = never, 1 = always, others as the % for 1/X.
// when not having action, it will be set to all actions in the categories
this.events = [
    {category: 'general', action: 'style_load', sample: 1},
    {category: 'general', action: 'stylish_load', sample: 1},
    {category: 'installed_styles_menu', action: null, sample: 1},
    {category: 'library_menu', action: null, sample: 1},
    {category: 'manage_installed_styles', action: null, sample: 1}
];

function injectGA() {

    // Standard Google Universal Analytics code
    (function (i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r;
        i[r] = i[r] || function () {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date();
        a = s.createElement(o),
            m = s.getElementsByTagName(o)[0];
        a.async = 1;
        a.src = g;
        m.parentNode.insertBefore(a, m)
    })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga'); // Note: https protocol here

    const isOpera = utils.getBrowser().name === "Opera";

    let gaID = (isOpera ? "UA-8246384-14" : "UA-8246384-12");
    ga('create', gaID, 'auto');
    ga('set', 'checkProtocolTask', function () {
    });
}

if (undefined === localStorage.GA_send_events) {
    //sampling one of 1000 users.
    if (42 === Math.floor(Math.random() * 1000)) {
        localStorage.GA_send_events = true;
    } else {
        localStorage.GA_send_events = false;
    }
}

injectGA();



function activeUserEvent(type, timeSince) {
    this.callEvent("Main KPIs", type + " Active user", timeSince);
}

function dailyActiveUser() {

    const userAge = parseInt(this.getUserAge());
    localStorage.setItem("age", userAge);
    const lastAge = parseInt(localStorage.getItem("lastAge") || 0);
    const timeSince = userAge - (lastAge || 0);
    localStorage.setItem("lastAge", userAge);

    if (userAge === 1 && !localStorage.getItem("D1")) {
        localStorage.setItem("D1", timeSince);
        this.activeUserEvent("D1", timeSince);
    } else if (userAge === 7 && !localStorage.getItem("D7")) {
        localStorage.setItem("D7", timeSince);
        this.activeUserEvent("D7", timeSince);
    } else if (userAge === 14 && !localStorage.getItem("D14")) {
        localStorage.setItem("D14", timeSince);
        this.activeUserEvent("D14", timeSince);
    } else if (userAge === 28 && !localStorage.getItem("D28")) {
        localStorage.setItem("D28", timeSince);
        this.activeUserEvent("D28", timeSince);
    } else if (userAge === 90 && !localStorage.getItem("D90")) {
        localStorage.setItem("D90", timeSince);
        this.activeUserEvent("D90", timeSince);
    }

}

function setDailyTracking() {
    this.dailyActiveUser();
    setInterval(this.dailyActiveUser.bind(this), 1000 * 60 * 5);
}

function getUserAge() {
    if (!localStorage.getItem("itemrstrtnq") || isNaN(localStorage.getItem("itemrstrtnq"))) {
        return 'N/A';
    } else {
        return Math.floor((new Date().getTime() - localStorage.getItem("itemrstrtnq")) / (1000 * 60 * 60 * 24));
    }
}

function callEvent(category, action, label, value) {

    if (!localStorage.getItem("itemrstrtnq")) {
        localStorage.setItem("itemrstrtnq", 'N/A');
    }
    if ((localStorage.hasOwnProperty("GA_send_events") && localStorage.GA_send_events === "true") || (action === "install")) {
        ga('send', 'event', category, action, label, value);
    }
}

function analyticsEvent(category, action, label, value) {

    const version = chrome.runtime.getManifest().version;
    if(label !== null)
        label = label + " & " + version;
    else
        label = version;

    //console.log("analytics event (before sampling) with arguments:", arguments, "and custom dimensions:", this.customDimension);

    if (!category)
        return;

    for (const event of this.events) {

        if (event.category === category.toLowerCase() && ((event.action && event.action === action.toLowerCase()) || !event.action)) {
            if (event.sample > 0 && (Math.floor(event.sample * Math.random()) + 1) === 1) {
                this.callEvent(category, action, label, value);
            }
            return;
        }
    }

    this.callEvent(category, action, label, value); //will send the event anyhow, as no sample rule was found.

}

chrome.runtime.onMessage.addListener(function (request, sender, sendResponse) {
    if (request.gacategory)
        analyticsEvent(request.gacategory, request.gaaction || null, request.galabel || null, request.gavalue || null);
});
