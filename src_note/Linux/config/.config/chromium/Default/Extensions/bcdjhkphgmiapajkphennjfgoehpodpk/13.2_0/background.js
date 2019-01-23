/************************************************************************/
/*                                                                      */
/*      Zoom Page WE - Firefox Extension - Background Page              */
/*                                                                      */
/*      Javascript for background page                                  */
/*                                                                      */
/*      Last Edit - 08 Dec 2018                                         */
/*                                                                      */
/*      Copyright (C) 2009-2018 DW-dev                                  */
/*                                                                      */
/*      Distributed under the GNU General Public License version 2      */
/*      See LICENCE.txt file and http://www.gnu.org/licenses/           */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Refer to Google Chrome developer documentation:                     */
/*                                                                      */
/*  https://developer.chrome.com/extensions/overview                    */
/*  https://developer.chrome.com/extensions/content_scripts             */
/*  https://developer.chrome.com/extensions/messaging                   */
/*  https://developer.chrome.com/extensions/optionsV2                   */
/*  https://developer.chrome.com/extensions/contentSecurityPolicy       */
/*                                                                      */
/*  https://developer.chrome.com/extensions/manifest                    */
/*  https://developer.chrome.com/extensions/declare_permissions         */
/*  https://developer.chrome.com/extensions/match_patterns              */
/*                                                                      */
/*  https://developer.chrome.com/extensions/browserAction               */
/*  https://developer.chrome.com/extensions/contextMenus                */
/*  https://developer.chrome.com/extensions/notifications               */
/*  https://developer.chrome.com/extensions/runtime                     */
/*  https://developer.chrome.com/extensions/storage                     */
/*  https://developer.chrome.com/extensions/tabs                        */
/*  https://developer.chrome.com/extensions/webNavigation               */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Full/Text Zoom is applied to these pages:                           */
/*                                                                      */
/*  - Zoomable                                                          */
/*    |                                                                 */
/*    +- SiteZoomable                                                   */
/*    |  |                                                              */
/*    |  +- Scriptable                      (full zoom or text zoom)    */
/*    |  |  |                                                           */
/*    |  |  +- http: or https: or file:     (per-site or per-tab)       */
/*    |  |     except                                                   */
/*    |  |       - Firefox                                              */
/*    |  |         - https://addons.mozilla.org                         */
/*    |  |       - Chrome                                               */
/*    |  |         - https://chrome.google.com/webstore                 */
/*    |  |         - https://www.google. ... /_/chrome/newtab           */
/*    |  |         - https://www.google. ... sourceid=chrome-instant    */
/*    |  |                                                              */
/*    |  +- Firefox                         (full zoom - not CSS)       */
/*    |     |                                                           */
/*    |     +- https://addons.mozilla.org   (per-site or per-tab)       */
/*    |     |                                                           */
/*    |     +- moz-extension:               (per-site or per-tab)       */
/*    |     |                                                           */
/*    |     +- about:                       (per-site or per-tab)       */
/*    |        except                                                   */
/*    |          - about:blank                                          */
/*    |                                                                 */
/*    +- Firefox                            (full zoom - not CSS)       */
/*       |                                                              */
/*       +- all pages                       (per-tab)                   */
/*          except                                                      */
/*            - about:blank                                             */
/*            - resource:                                               */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Minimum Font Size is applied to these pages:                        */
/*                                                                      */
/*  - Scriptable                            (minimum font size)         */
/*    |                                                                 */
/*    +- http: or https: or file:           (per-site or per-tab)       */
/*       except                                                         */
/*         - Firefox                                                    */
/*           - https://addons.mozilla.org                               */
/*         - Chrome                                                     */
/*           - https://chrome.google.com/webstore                       */
/*           - https://www.google. ... /_/chrome/newtab                 */
/*           - https://www.google. ... sourceid=chrome-instant          */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Subsites can be defined for these pages:                            */
/*                                                                      */
/*  - http: or https:                       (subsite root)              */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Subsites are defined based on levels of descendant pages:           */
/*                                                                      */
/*    Subsite Type                                                      */
/*                                                                      */
/*        *                       0     Page where subsite defined      */
/*                                                                      */
/*        >                     1 1 1                                   */
/*                                                                      */
/*        > 1                 2 2 2 2 2                                 */
/*                                                                      */
/*        > 2               3 3 3 3 3 3 3                               */
/*                       /-----------------\                            */
/*        > 3           / 4 4 4 4 4 4 4 4 4 \    Subsite > 3            */
/*                     /                     \                          */
/*        > 4         / 5 5 5 5 5 5 5 5 5 5 5 \    Includes all         */
/*                   /                         \    descendants         */
/*        > 5       / 6 6 6 6 6 6 6 6 6 6 6 6 6 \    except first       */
/*                 /                             \    3 levels          */
/*        > 6     / 7 7 7 7 7 7 7 7 7 7 7 7 7 7 7 \    (1,2,3)          */
/*               /                 .               \                    */
/*              /                  .                \                   */
/*             /                   .                 \                  */
/*            /---------------------------------------\                 */
/*                                                                      */
/************************************************************************/

"use strict";

/************************************************************************/

/* Global variables */

var isFirefox;
var ffVersion;

var platformOS;

var ffPrintEditId = "";
var gcPrintEditId = "";

var chromeLevels = "25 33 50 67 75 80 90 100 110 125 150 175 200 250 300 400 500";
var firefoxLevels = "30 50 67 80 90 100 110 120 133 150 170 200 240 300";

var fontSizes = new Array(0,9,10,11,12,13,14,15,16,17,18,20,22,24,26,28);

var minLevel,maxLevel;

var zoomMode,resetOnLoad,cssFullZoom,applyAutoFit,allowSubsites;
var defaultType;
var showBadge,showSubmenu;
var zoomLevels;
var defaultFullLevel;
var defaultTextLevel,defaultOtherLevel;
var zoomInOut,zoomStep;
var defaultSize;

var perTabReadyStates = new Array();
var perTabAutoFitHosts = new Array();  /* host for page in tab if autofit was applied - used to avoid applying autofit if next page has same host */
var perTabContentTypes = new Array();

var perTabZoomTypes = new Array();

var perSiteZoomTypes = new Object();
var perSiteZoomTypesNotIncognito = new Object();

var perTabZoomLevels = new Array();

var perSiteZoomLevels = new Object();
var perSiteZoomLevelsNotIncognito = new Object();

var perTabFontSizes = new Array();

var perSiteFontSizes = new Object();
var perSiteFontSizesNotIncognito = new Object();

var subsiteTypes = new Object();
var subsiteTypesNotIncognito = new Object();

var activeTabId = null;

var resizeFinishTimeout = null;
var resizeIgnoreTimeout = null;

var debugEnable = false;
var debugHistory = "";

/************************************************************************/

/* Initialize on browser startup */

chrome.runtime.getPlatformInfo(
function(PlatformInfo)
{
    platformOS = PlatformInfo.os;
    
    chrome.storage.local.set({ "environment-platformos": platformOS });
    
    isFirefox = (navigator.userAgent.indexOf("Firefox") >= 0);
    
    chrome.storage.local.set({ "environment-isfirefox": isFirefox });
    
    if (isFirefox)
    {
        chrome.runtime.getBrowserInfo(
        function(info)
        {
            ffVersion = info.version.substr(0,info.version.indexOf("."));
            
            chrome.storage.local.set({ "environment-ffversion": ffVersion });
            
            ffPrintEditId = "printedit-we@DW-dev";
            
            initialize();
        });
    }
    else
    {
        chrome.management.getSelf(
        function(extensionInfo)
        {
            gcPrintEditId = (extensionInfo.installType == "normal") ? "olnblpmehglpcallpnbgmikjblmkopia" : "dhblkjgdjeojbefdmhibhpgnpicdijbj";
            
            initialize();
        });
    }
});

function initialize()
{
    minLevel = isFirefox ? 30 : 25;
    maxLevel = isFirefox ? 300 : 500;
    
    if (isFirefox)
    {
        chrome.tabs.query({ lastFocusedWindow: true, active: true },
        function(tabs)
        {
            chrome.tabs.setZoom(tabs[0].id,0.001,  /* 0.1% */
            function()
            {
                var matches = new Array();
                
                if (chrome.runtime.lastError != null)
                {
                    // e.g. "Zoom value 0.001 out of range (must be between 0.3 and 3)"
                    
                    matches = chrome.runtime.lastError.message.match(/.*between ([\d\.]*) and ([\d\.]*)/i);
                    
                    minLevel = matches[1]*100;
                    maxLevel = matches[2]*100;
                }
            });
        });
    }
    
    chrome.storage.local.get(null,
    function(object)
    {
        var site,subsite,context;
        
        /* Initialize or migrate options */
        
        if (!("options-zoommode" in object)) object["options-zoommode"] = 0;
        
        if (!("options-resetonload" in object)) object["options-resetonload"] = isFirefox ? false : true;
        
        if (!("options-cssfullzoom" in object)) object["options-cssfullzoom"] =
            ("options-usecsszoom" in object) ? object["options-usecsszoom"] : (isFirefox ? false : true);  /* Version 2.0-3.3 */
        
        if (!("options-applyautofit" in object)) object["options-applyautofit"] =
            ("options-defaultautofit" in object) ? object["options-defaultautofit"] : false;  /* Version 6.0-6.2 */
        
        if (!("options-allowsubsites" in object)) object["options-applyautofit"] = false;
        
        if (!("options-defaulttype" in object)) object["options-defaulttype"] = 0;
        
        if (!("options-enablescaling" in object)) object["options-enablescaling"] =
            ("options-scaleimages" in object) ? object["options-scaleimages"] : true;  /* Version 7.1 */
        
        if (!("options-applyscaling" in object)) object["options-applyscaling"] =
            ("options-scaleimages" in object) ? object["options-scaleimages"] : false;  /* Version 7.1 */
        
        if (!("options-showbadge" in object)) object["options-showbadge"] = true; 
        
        if (!("options-showsubmenu" in object)) object["options-showsubmenu"] = 
            ("options-showmenu" in object) ? object["options-showmenu"] : true;  /* Version 3.0-3.3 */
        
        if (!("options-enablectrl789" in object)) object["options-enablectrl789"] = true;
        
        if (!("options-enablerightwheel" in object)) object["options-enablerightwheel"] = true;
        
        if (!("options-zoomlevels" in object))
            object["options-zoomlevels"] = isFirefox ? firefoxLevels.split(" ").map(Number) : chromeLevels.split(" ").map(Number);
        else if (!Array.isArray(object["options-zoomlevels"]))
            object["options-zoomlevels"] = object["options-zoomlevels"].split(" ").map(Number);  /* Version 1.0 */
        
        if (!("options-defaultfulllevel" in object)) object["options-defaultfulllevel"] =
            ("options-defaultlevel" in object) ? object["options-defaultlevel"] : 100;  /* Version 1.0-3.3 */
        
        if (!("options-defaulttextlevel" in object)) object["options-defaulttextlevel"] = 100;
        
        if (!("options-defaultotherlevel" in object)) object["options-defaultotherlevel"] = 100;
        
        if (!("options-autominlevel" in object)) object["options-autominlevel"] =
            ("options-minautolevel" in object) ? object["options-minautolevel"] : 67;  /* Version 1.0-3.3 */
        
        if (!("options-automaxlevel" in object)) object["options-automaxlevel"] =
            ("options-maxautolevel" in object) ? object["options-maxautolevel"] : 150;  /* Version 1.0-3.3 */
        
        if (!("options-zoominout" in object)) object["options-zoominout"] = 0;
        
        if (!("options-zoomstep" in object)) object["options-zoomstep"] = 10;
        
        if (!("options-defaultsize" in object)) object["options-defaultsize"] =
            ("options-minfontsize" in object) ? object["options-minfontsize"] : 0;  /* Version 1.0-2.1.1 */
        
        if (!("options-adjustlinespace" in object)) object["options-adjustlinespace"] = false;
        
        if (!("options-linespacefactor" in object)) object["options-linespacefactor"] = 1.2;
        
        if (!("options-applytodynamic" in object)) object["options-applytodynamic"] = true;
        
        if (!("persite-zoomtypes" in object)) object["persite-zoomtypes"] = new Object();
        
        if (!("persite-zoomlevels" in object)) object["persite-zoomlevels"] = new Object();
        
        if (!("persite-fontsizes" in object)) object["persite-fontsizes"] = new Object();
        
        if (!("subsite-types" in object)) object["subsite-types"] = new Object();
        
        /* Update stored options */
        
        chrome.storage.local.set(object);
        
        /* Initialize local options */
        
        zoomMode = object["options-zoommode"];
        resetOnLoad = object["options-resetonload"];
        cssFullZoom = object["options-cssfullzoom"];
        applyAutoFit = object["options-applyautofit"];
        allowSubsites = object["options-allowsubsites"];
        
        defaultType = object["options-defaulttype"];
        
        showBadge = object["options-showbadge"];
        showSubmenu = object["options-showsubmenu"];
        zoomLevels = object["options-zoomlevels"];
        
        defaultFullLevel = object["options-defaultfulllevel"];
        defaultTextLevel = object["options-defaulttextlevel"];
        defaultOtherLevel = object["options-defaultotherlevel"];
        
        zoomInOut = object["options-zoominout"];
        zoomStep = object["options-zoomstep"];
        
        defaultSize = object["options-defaultsize"];
        
        /* Initialize per site zoom types, zoom levels and font sizes */
        
        perSiteZoomTypesNotIncognito = object["persite-zoomtypes"];
        
        for (site in perSiteZoomTypesNotIncognito)
        {
            if (perSiteZoomTypesNotIncognito.hasOwnProperty(site)) perSiteZoomTypes[site] = perSiteZoomTypesNotIncognito[site];
        }
        
        perSiteZoomLevelsNotIncognito = object["persite-zoomlevels"];
        
        for (site in perSiteZoomLevelsNotIncognito)
        {
            if (perSiteZoomLevelsNotIncognito.hasOwnProperty(site)) perSiteZoomLevels[site] = perSiteZoomLevelsNotIncognito[site];
        }
        
        perSiteFontSizesNotIncognito = object["persite-fontsizes"];
        
        for (site in perSiteFontSizesNotIncognito)
        {
            if (perSiteFontSizesNotIncognito.hasOwnProperty(site)) perSiteFontSizes[site] = perSiteFontSizesNotIncognito[site];
        }
        
        /* Initialize sub-site types */
        
        subsiteTypesNotIncognito = object["subsite-types"];
        
        for (subsite in subsiteTypesNotIncognito)
        {
            if (subsiteTypesNotIncognito.hasOwnProperty(subsite)) subsiteTypes[subsite] = subsiteTypesNotIncognito[subsite];
        }
        
        /* Check Firefox browser.zoom.siteSpecific preference is correctly set */
        
        if (isFirefox)
        {
            window.setTimeout(function() { checkZoomSettings(); },1000);  /* Firefox - workaround until chrome.tabs.setZoomSettings supports changing scope */  /*???*/
        }
        
        /* Add context menu items */
        
        context = showSubmenu ? "all" : "browser_action";
        
        chrome.contextMenus.create({ id: "zoomin", title: "Zoom In", contexts: [ context ], enabled: true });
        chrome.contextMenus.create({ id: "zoomout", title: "Zoom Out", contexts: [ context ], enabled: true });
        chrome.contextMenus.create({ id: "zoomreset", title: "Zoom Reset", contexts: [ context ], enabled: true });
        chrome.contextMenus.create({ id: "zoomtype", title: "Zoom Type", contexts: [ context ], enabled: true });
        chrome.contextMenus.create({ id: "zoomautofit", title: "Zoom AutoFit", contexts: [ context ], enabled: true });
        chrome.contextMenus.create({ id: "fontreset", title: "Font Reset", contexts: [ context ], enabled: true });
        
        /* Add listeners */
        
        addListeners();
        
        /* Handle first load in first tab */
        
        chrome.tabs.query({ lastFocusedWindow: true, active: true },
        function(tabs)
        {
            debugHistory += "Startup(" + tabs[0].id + ")";
            debugHistory += "[" + getSiteZoomType(tabs[0].url) + "," + getSiteZoomLevel(tabs[0].url) + "%]";
            debugHistory += "{" + getHost(tabs[0].url) + "}, ";
            
            activeTabId = tabs[0].id;
            
            perTabReadyStates[tabs[0].id] = tabs[0].status;
            
            definePerTabValues(tabs[0].id,tabs[0].url);  /* Firefox - values will be undefined for first load in first tab if page non-scriptable */
            
            webNavigationLoading(tabs[0].id,tabs[0].url,true);
        });
    });
}

/************************************************************************/

/* Add listeners */

function addListeners()
{
    /* Storage changed listener */
    
    chrome.storage.onChanged.addListener(
    function(changes,areaName)
    {
        chrome.storage.local.get(null,
        function(object)
        {
            var context;
            
            zoomMode = object["options-zoommode"];
            resetOnLoad = object["options-resetonload"];
            cssFullZoom = object["options-cssfullzoom"];
            applyAutoFit = object["options-applyautofit"];
            allowSubsites = object["options-allowsubsites"];
            
            defaultType = object["options-defaulttype"]; 
            
            showBadge = object["options-showbadge"];
            showSubmenu = object["options-showsubmenu"];
            zoomLevels = object["options-zoomlevels"];
            
            defaultFullLevel = object["options-defaultfulllevel"];
            defaultTextLevel = object["options-defaulttextlevel"];
            defaultOtherLevel = object["options-defaultotherlevel"];
            
            zoomInOut = object["options-zoominout"];
            zoomStep = object["options-zoomstep"];
            
            defaultSize = object["options-defaultsize"];
            
            if ("options-cssfullzoom" in changes) changeFullZoomMethod();
            
            if ("options-showbadge" in changes)
            {
                chrome.tabs.query({ lastFocusedWindow: true, active: true },
                function(tabs)
                {
                    definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
                    
                    if (zoomablePage(tabs[0].url))
                    {
                        updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                    }
                });
            }
            
            if ("options-showsubmenu" in changes)
            {
                context = showSubmenu ? "all" : "browser_action";
                
                chrome.contextMenus.update("zoomin",{ contexts: [ context ] });
                chrome.contextMenus.update("zoomout",{ contexts: [ context ] });
                chrome.contextMenus.update("zoomreset",{ contexts: [ context ] });
                chrome.contextMenus.update("zoomtype",{ contexts: [ context ] });
                chrome.contextMenus.update("zoomautofit", { contexts: [ context ] });
                chrome.contextMenus.update("fontreset", { contexts: [ context ] });
            }
            
            /* Check Firefox browser.zoom.siteSpecific preference is correctly set */
            
            if (isFirefox)
            {
                if ("options-zoommode" in changes)
                {
                    window.setTimeout(function() { checkZoomSettings(); },1000);  /* Firefox - workaround until chrome.tabs.setZoomSettings supports changing scope */  /*???*/
                }
            }
        });
    });
    
    /* Context menu listener */
    
    chrome.contextMenus.onClicked.addListener(
    function(info,tab)
    {
        if (info.menuItemId == "zoomin") zoomIn();
        else if (info.menuItemId == "zoomout") zoomOut();
        else if (info.menuItemId == "zoomreset") zoomReset();
        else if (info.menuItemId == "zoomtype") zoomType();
        else if (info.menuItemId == "zoomautofit") zoomAutoFit();
        else if (info.menuItemId == "fontreset") fontReset();
    });
    
    /* Tab event listeners */
    
    chrome.tabs.onCreated.addListener(
    function(tab)
    {
        /* Chrome - not called for first tab */
        
        debugHistory += "Created(" + tab.id + "), ";
        
        definePerTabValues(tab.id,tab.url);  /* will be undefined */
    });
    
    chrome.tabs.onActivated.addListener(
    function(activeInfo)
    {
        if (activeTabId != null) chrome.tabs.sendMessage(activeTabId,{ type: "tabactivated" },checkError);
        
        chrome.tabs.get(activeInfo.tabId,
        function(tab)
        {
            if (chrome.runtime.lastError == null)  /* sometimes tab does not exist */
            {
                debugHistory += "Activated(" + activeInfo.tabId + ")";
                debugHistory += "[" + getSiteZoomType(tab.url) + "," + getSiteZoomLevel(tab.url) + "%]";
                debugHistory += "{" + getHost(tab.url) + "}, ";
                
                definePerTabValues(activeInfo.tabId,tab.url);  /* Firefox - values will be undefined for pending tab */
                
                updateBrowserAction(activeInfo.tabId,tab.url,perTabZoomTypes[activeInfo.tabId],perTabZoomLevels[activeInfo.tabId],perTabFontSizes[activeInfo.tabId]);
                
                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[activeInfo.tabId], zoomlevel: perTabZoomLevels[activeInfo.tabId] },checkError);
                
                chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[activeInfo.tabId] },checkError);
                
                activeTabId = activeInfo.tabId;
            }
        });
    });
    
    chrome.tabs.onUpdated.addListener(
    function(tabId,changeInfo,tab)
    {
        debugHistory += "Updated(" + tabId + ")";
        debugHistory += "[" + getSiteZoomType(tab.url) + "," + getSiteZoomLevel(tab.url) + "%]";
        debugHistory += "{" + getHost(tab.url) + "}, ";
        
        definePerTabValues(tabId,tab.url);  /* in case undefined */
        
        updateBrowserAction(tabId,tab.url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
        
        if (tab.active)
        {
            chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabId], zoomlevel: perTabZoomLevels[tabId] },checkError);
            
            chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabId] },checkError);
        }
    });
    
    chrome.tabs.onZoomChange.addListener(
    function(zoomChangeInfo)
    {
        chrome.tabs.get(zoomChangeInfo.tabId,
        function(tab)
        {
            var level;
            
            debugHistory += "ZoomChange(" + zoomChangeInfo.tabId + ")";
            debugHistory += "<" + perTabReadyStates[zoomChangeInfo.tabId] + ">";
            debugHistory += "[~" + Math.round(zoomChangeInfo.newZoomFactor*100) + "%~]";
            debugHistory += "{" + getHost(tab.url) + "}, ";
            
            definePerTabValues(tab.id,tab.url);  /* in case undefined */
            
            if (zoomablePage(tab.url))
            {
                if (perTabZoomTypes[tab.id] == 0 && !cssFullZoom)
                {
                    level = Math.round(zoomChangeInfo.newZoomFactor*100);
                    
                    if (level != perTabZoomLevels[tab.id])  /* zoom level changed */
                    {
                        if (typeof perTabReadyStates[zoomChangeInfo.tabId] == "undefined" || perTabReadyStates[zoomChangeInfo.tabId] != "complete")  /* tab loading - override change */
                        {
                            setZoomTypeLevel(tab.id,tab.url,perTabZoomTypes[tab.id],perTabZoomLevels[tab.id],
                            function(tabId,url)
                            {
                                updateBrowserAction(tab.id,tab.url,perTabZoomTypes[tab.id],perTabZoomLevels[tab.id],perTabFontSizes[tab.id]);
                                
                                if (tab.active)
                                {
                                    chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tab.id], zoomlevel: perTabZoomLevels[tab.id] },checkError);
                                }
                            });
                        }
                        else  /* tab loaded - probably user change using Firefox zoom control - update to reflect change */
                        {
                            perTabZoomLevels[tab.id] = level;
                            
                            if (zoomMode == 0 && siteZoomablePage(tab.url) && !imagePage(tab.id)) updateSiteZoomLevel(tab.url,tab.incognito,level);  /* Per-Site */
                            
                            updateBrowserAction(tab.id,tab.url,perTabZoomTypes[tab.id],perTabZoomLevels[tab.id],perTabFontSizes[tab.id]);
                            
                            if (tab.active)
                            {
                                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tab.id], zoomlevel: perTabZoomLevels[tab.id] },checkError);
                            }
                        }
                    }
                    else
                    {
                        updateBrowserAction(tab.id,tab.url,perTabZoomTypes[tab.id],perTabZoomLevels[tab.id],perTabFontSizes[tab.id]);
                        
                        if (tab.active)
                        {
                            chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tab.id], zoomlevel: perTabZoomLevels[tab.id] },checkError);
                        }
                    }
                    
                }
            }
        });
    });
    
    /* Web navigation listeners */
    
    chrome.webNavigation.onCommitted.addListener(
    function(details)
    {
        debugHistory += "Committed(" + details.tabId + ")";
        debugHistory += "<" + details.frameId + ">";
        debugHistory += "[" + getSiteZoomType(details.url) + "," + getSiteZoomLevel(details.url) + "%]";
        debugHistory += "{" + getHost(details.url) + "}, ";
        
        if (details.frameId == 0)  /* top-level frame - main document */
        {
            perTabReadyStates[details.tabId] = "loading";
            
            perTabContentTypes[details.tabId] = null;
            
            definePerTabValues(details.tabId,details.url);  /* Chrome - values will be undefined for first load in first tab */
            
            webNavigationLoading(details.tabId,details.url,false);
        }
    });
    
    chrome.webNavigation.onDOMContentLoaded.addListener(
    function(details)
    {
        debugHistory += "DOMloaded(" + details.tabId + ")";
        debugHistory += "<" + details.frameId + ">";
        debugHistory += "[" + getSiteZoomType(details.url) + "," + getSiteZoomLevel(details.url) + "%]";
        debugHistory += "{" + getHost(details.url) + "}, ";
        
        if (details.frameId == 0)  /* top-level frame - main document */
        {
            perTabReadyStates[details.tabId] = "interactive";
            
            definePerTabValues(details.tabId,details.url);  /* in case undefined */
            
            webNavigationLoading(details.tabId,details.url,false);
        }
    });
    
    chrome.webNavigation.onCompleted.addListener(
    function(details)
    {
        chrome.tabs.get(details.tabId,
        function(tab)
        {
            debugHistory += "Completed(" + details.tabId + ")";
            debugHistory += "<" + details.frameId + ">";
            debugHistory += "[" + getSiteZoomType(details.url) + "," + getSiteZoomLevel(details.url) + "%]";
            debugHistory += "{" + getHost(details.url) + "}, ";
            
            if (details.frameId == 0 && details.url != tab.url) return;  /* Firefox - workaround for when download popup window opens in Firefox */
            
            if (details.frameId == 0)  /* top-level frame - main document */
            {
                /* delay update of perTabReadyStates so this zoom after page load complete is ignored in chrome.tabs.onZoomChange listener */
                
                window.setTimeout(function(tabId) { perTabReadyStates[tabId] = "complete"; },100,details.tabId);
                
                definePerTabValues(details.tabId,details.url);  /* in case undefined */
                
                webNavigationLoading(details.tabId,details.url,true);
            }
        });
    });
    
    /* Message received listener */
    
    chrome.runtime.onMessage.addListener(
    function(message,sender,sendResponse)
    {
        switch (message.type)
        {
            /* Messages from popup script or content scripts */
            
            case "fontreset":
                
                fontReset();
                
                break;
                
            case "zoomreset":
                
                zoomReset();
                
                break;
                
            case "zoomautofit":
                
                zoomAutoFit();
                
                break;
                
            case "zoomtype":
                
                zoomType();
                
                break;
                
            case "zoomin":
                
                zoomIn();
                
                break;
                
            case "zoomout":
                
                zoomOut();
                
                break;
                
            /* Messages from popup script */
            
            case "popupopened":
                
                chrome.tabs.query({ lastFocusedWindow: true, active: true },
                function(tabs)
                {
                    chrome.runtime.sendMessage({ type: "contenttype", contenttype: perTabContentTypes[tabs[0].id] },checkError);
                    
                    definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
                    
                    chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
                    
                    chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
                    
                    chrome.runtime.sendMessage({ type: "newsubsitetype", subsitetype: getSubsiteType(tabs[0].url) },checkError);
                });
                
                break;
                
            case "subsiteclear":
                
                subsiteClear();
                
                break;
                
            case "subsitetypeselect":
                
                subsiteTypeSelect(message.subsitetype);
                
                break;
                
            case "fontup":
                
                fontUp();
                
                break;
                
            case "fontdown":
                
                fontDown();
                
                break;
                
            case "fontsizeselect":
                
                fontSizeSelect(message.fontsize);
                
                break;
                
            case "zoomlevelselect":
                
                zoomLevelSelect(message.zoomlevel);
                
                break;
                
            case "debug":
                
                if (debugEnable) console.log("Zoom Page WE Debug History:\n" + debugHistory);
                
                debugHistory = "";
                
                break;
                
            /* Messages from content scripts */
            
            case "scriptloaded":  /* content script loaded */
                
                if (sender.frameId == 0) perTabContentTypes[sender.tab.id] = message.contenttype;
                
                definePerTabValues(sender.tab.id,sender.tab.url);  /* in case undefined */
                
                sendResponse({ zoomtype: perTabZoomTypes[sender.tab.id], zoomlevel: perTabZoomLevels[sender.tab.id], fontsize: perTabFontSizes[sender.tab.id] });
                
                updateBrowserAction(sender.tab.id,sender.tab.url,perTabZoomTypes[sender.tab.id],perTabZoomLevels[sender.tab.id],perTabFontSizes[sender.tab.id]);
                
                break;
                
            case "initialized":  /* DOM content loaded or later */
                
                definePerTabValues(sender.tab.id,sender.tab.url);  /* in case undefined */
                
                webNavigationLoading(sender.tab.id,sender.tab.url,false);
                
                break;
                
            case "imageloaded":  /* standalone image document loaded */
                
                if (sender.frameId == 0)
                {
                    /* delay update of perTabReadyStates so this zoom is ignored in chrome.tabs.onZoomChange listener */
                    
                    window.setTimeout(function(tabId) { perTabReadyStates[tabId] = "complete"; },100,sender.tab.id);
                    
                    definePerTabValues(sender.tab.id,sender.tab.url);  /* in case undefined */
                    
                    webNavigationLoading(sender.tab.id,sender.tab.url,false);
                }
                
                break;
                
            case "imageclicked":  /* standalone image clicked */
                
                if (sender.frameId == 0)
                {
                    setZoomTypeLevel(sender.tab.id,sender.tab.url,0,100,
                    function(tabId,url)
                    {
                        updateBrowserAction(sender.tab.id,sender.tab.url,perTabZoomTypes[sender.tab.id],perTabZoomLevels[sender.tab.id],perTabFontSizes[sender.tab.id]);
                        
                        chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[sender.tab.id], zoomlevel: perTabZoomLevels[sender.tab.id] },checkError);
                    });
                    
                    setFontSize(sender.tab.id,sender.tab.url,0,
                    function(tabId,url)
                    {
                        updateBrowserAction(sender.tab.id,sender.tab.url,perTabZoomTypes[sender.tab.id],perTabZoomLevels[sender.tab.id],perTabFontSizes[sender.tab.id]);
                        
                        chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[sender.tab.id] },checkError);
                    });
                }
                
                break;
                
            case "autofitrepeat":
                
                if (sender.frameId == 0)
                {
                    setZoomTypeLevel(sender.tab.id,sender.tab.url,perTabZoomTypes[sender.tab.id],message.zoomlevel,
                    function(tabId,url)
                    {
                        chrome.tabs.sendMessage(tabId,{ type: "autofititerate", setsite: message.setsite },{ frameId: 0 },checkError);
                    });
                }
                
                break;
                
            case "autofitfinish":
                
                if (sender.frameId == 0)
                {
                    if (message.setsite)
                    {
                        if (zoomMode == 0 && siteZoomablePage(sender.tab.url)) updateSiteZoomLevel(sender.tab.url,sender.tab.incognito,perTabZoomLevels[sender.tab.id]);
                    }
                    else
                    {
                        if (zoomMode == 0 && siteZoomablePage(sender.tab.url))
                        {
                            window.setTimeout(  /* allow time for setZoomTypeLevel() to complete */
                            function()
                            {
                                clearSiteZoomLevel(sender.tab.url);
                            },10);
                        }
                    }
                    
                    updateBrowserAction(sender.tab.id,sender.tab.url,perTabZoomTypes[sender.tab.id],perTabZoomLevels[sender.tab.id],perTabFontSizes[sender.tab.id]);
                    
                    chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[sender.tab.id], zoomlevel: perTabZoomLevels[sender.tab.id] },checkError);
                }
                
                break;
                
            case "resize":
                
                if (sender.frameId == 0)
                {
                    handleBrowserResize(sender.tab.id,sender.tab.url);
                }
                
                break;
                
            /* Messages from options script */
            
            case "clearsitedata":
                
                if (zoomMode == 0)  /* Per-Site */
                {
                    chrome.tabs.query({ },
                    function(tabs)
                    {
                        var i,type;
                        
                        for (i = 0; i < tabs.length; i++)
                        {
                            definePerTabValues(tabs[i].id,tabs[i].url);  /* in case undefined */
                            
                            if (siteZoomablePage(tabs[i].url))
                            {
                                type = (!scriptablePage(tabs[i].url)) ? 0 : defaultType;
                                
                                setZoomTypeLevel(tabs[i].id,tabs[i].url,type,(type == 0) ?  defaultFullLevel : defaultTextLevel,
                                function(tabId,url)
                                {
                                    updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                                    
                                    if (tabId == activeTabId)
                                    {
                                        chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabId], zoomlevel: perTabZoomLevels[tabId] },checkError);
                                    }
                                });
                                
                                setFontSize(tabs[i].id,tabs[i].url,defaultSize,
                                function(tabId,url)
                                {
                                    updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                                    
                                    if (tabId == activeTabId)
                                    {
                                        chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabId] },checkError);
                                    }
                                });
                            }
                        }
                    });
                }
                
                window.setTimeout(  /* allow time for setZoomTypeLevel()'s and setFontSize()'s to complete */
                function()
                {
                    var site,subsite;
                    
                    for (site in perSiteZoomTypes)
                    {
                        if (perSiteZoomTypes.hasOwnProperty(site)) delete perSiteZoomTypes[site];
                    }
                    
                    for (site in perSiteZoomTypesNotIncognito)
                    {
                        if (perSiteZoomTypesNotIncognito.hasOwnProperty(site)) delete perSiteZoomTypesNotIncognito[site];
                    }
                    
                    for (site in perSiteZoomLevels)
                    {
                        if (perSiteZoomLevels.hasOwnProperty(site)) delete perSiteZoomLevels[site];
                    }
                    
                    for (site in perSiteZoomLevelsNotIncognito)
                    {
                        if (perSiteZoomLevelsNotIncognito.hasOwnProperty(site)) delete perSiteZoomLevelsNotIncognito[site];
                    }
                    
                    for (site in perSiteFontSizes)
                    {
                        if (perSiteFontSizes.hasOwnProperty(site)) delete perSiteFontSizes[site];
                    }
                    
                    for (site in perSiteFontSizesNotIncognito)
                    {
                        if (perSiteFontSizesNotIncognito.hasOwnProperty(site)) delete perSiteFontSizesNotIncognito[site];
                    }
                    
                    for (subsite in subsiteTypes)
                    {
                        if (subsiteTypes.hasOwnProperty(subsite)) delete subsiteTypes[subsite];
                    }
                    
                    for (subsite in subsiteTypesNotIncognito)
                    {
                        if (subsiteTypesNotIncognito.hasOwnProperty(subsite)) delete subsiteTypesNotIncognito[subsite];
                    }
                    
                    chrome.storage.local.set(
                    {
                        "persite-zoomtypes": perSiteZoomTypesNotIncognito,
                        
                        "persite-zoomlevels": perSiteZoomLevelsNotIncognito,
                        
                        "persite-fontsizes": perSiteFontSizesNotIncognito,
                        
                        "subsite-types": subsiteTypesNotIncognito
                    });
                },100);
                
                break;
        }
    });
    
    /* External message received listener */
    
    if (!isFirefox || ffVersion >= 54)
    {
        chrome.runtime.onMessageExternal.addListener(
        function(message,sender,sendResponse)
        {
            switch (message.type)
            {
                /* Messages from another add-on */
                
                case "externalReset":
                    
                    if (sender.id == ffPrintEditId || sender.id == gcPrintEditId)
                    {
                        chrome.tabs.query({ lastFocusedWindow: true, active: true },
                        function(tabs)
                        {
                            definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
                            
                            if (zoomablePage(tabs[0].url))
                            {
                                setZoomTypeLevel(tabs[0].id,tabs[0].url,0,100,
                                function(tabId,url)
                                {
                                    if (zoomMode == 0 && siteZoomablePage(tabs[0].url))
                                    {
                                        updateSiteZoomType(tabs[0].url,tabs[0].incognito,perTabZoomTypes[tabs[0].id]);
                                        
                                        updateSiteZoomLevel(tabs[0].url,tabs[0].incognito,perTabZoomLevels[tabs[0].id]);
                                    }
                                    
                                    updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                                    
                                    chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
                                });
                            }
                            
                            if (scriptablePage(tabs[0].url))
                            {
                                setFontSize(tabs[0].id,tabs[0].url,0,
                                function(tabId,url)
                                {            
                                    if (zoomMode == 0) updateSiteFontSize(tabs[0].url,tabs[0].incognito,perTabFontSizes[tabs[0].id]);
                                    
                                    updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                                    
                                    chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
                                });
                            }
                        });
                    }
                    
                    break;
            }
        });
    }
}

/************************************************************************/

/* Subsite functions */

function subsiteClear()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        updateSubsiteType(tabs[0].url,tabs[0].incognito,1);
        
        clearSiteZoomType(tabs[0].url);
        clearSiteZoomLevel(tabs[0].url);
        clearSiteFontSize(tabs[0].url);
        
        clearSubsiteType(tabs[0].url);
        
        chrome.runtime.sendMessage({ type: "newsubsitetype", subsitetype: 0 },checkError);
        
        setZoomTypeLevel(tabs[0].id,tabs[0].url,getSiteZoomType(tabs[0].url),getSiteZoomLevel(tabs[0].url),
        function(tabId,url)
        {
            updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
            
            chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
        });
        
        setFontSize(tabs[0].id,tabs[0].url,getSiteFontSize(tabs[0].url),
        function(tabId,url)
        {
            updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
            
            chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
        });
    });
}

function subsiteTypeSelect(subsitetype)
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        var hastype,haslevel,hassize,type,level,size;
        
        hastype = hasSiteZoomType(tabs[0].url);
        haslevel = hasSiteZoomLevel(tabs[0].url);
        hassize = hasSiteFontSize(tabs[0].url);
        
        type = getSiteZoomType(tabs[0].url);
        level = getSiteZoomLevel(tabs[0].url);
        size = getSiteFontSize(tabs[0].url);
        
        updateSubsiteType(tabs[0].url,tabs[0].incognito,1);
        
        if (hastype) updateSiteZoomType(tabs[0].url,tabs[0].incognito,type);
        if (haslevel) updateSiteZoomLevel(tabs[0].url,tabs[0].incognito,level);
        if (hassize) updateSiteFontSize(tabs[0].url,tabs[0].incognito,size);
        
        updateSubsiteType(tabs[0].url,tabs[0].incognito,subsitetype);
        
        chrome.runtime.sendMessage({ type: "newsubsitetype", subsitetype: subsitetype },checkError);
        
        updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
    });
}

/************************************************************************/

/* Font functions */

function fontReset()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (scriptablePage(tabs[0].url))
        {
            setFontSize(tabs[0].id,tabs[0].url,defaultSize,
            function(tabId,url)
            {            
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
                
                if (zoomMode == 0)  /* Per-Site */
                {
                    window.setTimeout(  /* allow time for setFontSize() to complete */
                    function()
                    {
                        clearSiteFontSize(tabs[0].url);
                    },10);
                }
            });
        }
    });
}

function fontUp()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        var i,size;
        
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (scriptablePage(tabs[0].url))
        {
            for (i = 0; i < fontSizes.length; i++)
                if (fontSizes[i] > perTabFontSizes[tabs[0].id]) break;
            
            if (i > fontSizes.length-1) i = fontSizes.length-1;
            
            size = fontSizes[i];
            
            setFontSize(tabs[0].id,tabs[0].url,size,
            function(tabId,url)
            {            
                if (zoomMode == 0) updateSiteFontSize(tabs[0].url,tabs[0].incognito,perTabFontSizes[tabs[0].id]);
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
            });
        }
    });
}

function fontDown()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        var i,size;
        
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (scriptablePage(tabs[0].url))
        {
            for (i = fontSizes.length-1; i >= 0; i--)
                if (fontSizes[i] < perTabFontSizes[tabs[0].id]) break;
            
            if (i < 0) i = 0;
            
            size = fontSizes[i];
            
            setFontSize(tabs[0].id,tabs[0].url,size,
            function(tabId,url)
            {            
                if (zoomMode == 0) updateSiteFontSize(tabs[0].url,tabs[0].incognito,perTabFontSizes[tabs[0].id]);
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
            });
        }
    });
}

function fontSizeSelect(size)
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (scriptablePage(tabs[0].url))
        {
            setFontSize(tabs[0].id,tabs[0].url,size,
            function(tabId,url)
            {            
                if (zoomMode == 0) updateSiteFontSize(tabs[0].url,tabs[0].incognito,perTabFontSizes[tabs[0].id]);
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabs[0].id] },checkError);
            });
        }
    });
}

/************************************************************************/

/* Zoom functions */

function zoomReset()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (applyAutoFit && scriptablePage(tabs[0].url) && !imagePage(tabs[0].id))
        {
            perTabAutoFitHosts[tabs[0].id] = getHost(tabs[0].url);
            
            chrome.tabs.sendMessage(tabs[0].id,{ type: "autofitstart", setsite: false },{ frameId: 0 },checkError);
        }
        else if (zoomablePage(tabs[0].url))
        {
            perTabAutoFitHosts[tabs[0].id] = null;
            
            setZoomTypeLevel(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],(perTabZoomTypes[tabs[0].id] == 0) ? defaultFullLevel : defaultTextLevel,
            function(tabId,url)
            {
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
                
                if (zoomMode == 0 && siteZoomablePage(tabs[0].url))  /* Per-Site */
                {
                    window.setTimeout(  /* allow time for setZoomTypeLevel() to complete */
                    function()
                    {
                        clearSiteZoomLevel(tabs[0].url);
                    },10);
                }
            });
        }
    });
}

function zoomAutoFit()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (scriptablePage(tabs[0].url) && !imagePage(tabs[0].id))
        {
            perTabAutoFitHosts[tabs[0].id] = getHost(tabs[0].url);
            
            chrome.tabs.sendMessage(tabs[0].id,{ type: "autofitstart", setsite: !applyAutoFit },{ frameId: 0 },checkError);
        }
    });
}

function zoomType()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (scriptablePage(tabs[0].url))
        {
            setZoomTypeLevel(tabs[0].id,tabs[0].url,1-perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],
            function(tabId,url)
            {
                if (zoomMode == 0)
                {
                    updateSiteZoomType(tabs[0].url,tabs[0].incognito,perTabZoomTypes[tabs[0].id]);
                    
                    updateSiteZoomLevel(tabs[0].url,tabs[0].incognito,perTabZoomLevels[tabs[0].id]);
                }
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
            });
        }
    });
}

function zoomIn()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        var i,level;
        
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (zoomablePage(tabs[0].url))
        {
            if (zoomInOut == 0)  /* to next level */
            {
                for (i = 0; i < zoomLevels.length; i++)
                    if (zoomLevels[i] > perTabZoomLevels[tabs[0].id]) break;
                
                if (i > zoomLevels.length-1) i = zoomLevels.length-1;
                
                level = zoomLevels[i];
            }
            else  /* by fixed step */
            {
                level = perTabZoomLevels[tabs[0].id]+zoomStep;
            }
            
            if (level > maxLevel) level = maxLevel;
            
            setZoomTypeLevel(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],level,
            function(tabId,url)
            {
                if (zoomMode == 0 && siteZoomablePage(tabs[0].url) && !imagePage(tabs[0].id)) updateSiteZoomLevel(tabs[0].url,tabs[0].incognito,perTabZoomLevels[tabs[0].id]);
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
            });
        }
    });
}

function zoomOut()
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        var i,level;
        
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (zoomablePage(tabs[0].url))
        {
            if (zoomInOut == 0)  /* to next level */
            {
                for (i = zoomLevels.length-1; i >= 0; i--)
                    if (zoomLevels[i] < perTabZoomLevels[tabs[0].id]) break;
                
                if (i < 0) i = 0;
                
                level = zoomLevels[i];
            }
            else  /* by fixed step */
            {
                level = perTabZoomLevels[tabs[0].id]-zoomStep;
            }
            
            if (level < minLevel) level = minLevel;
            
            setZoomTypeLevel(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],level,
            function(tabId,url)
            {
                if (zoomMode == 0 && siteZoomablePage(tabs[0].url) && !imagePage(tabs[0].id)) updateSiteZoomLevel(tabs[0].url,tabs[0].incognito,perTabZoomLevels[tabs[0].id]);
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
            });
        }
    });
}

function zoomLevelSelect(level)
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        definePerTabValues(tabs[0].id,tabs[0].url);  /* in case undefined */
        
        if (zoomablePage(tabs[0].url))
        {
            if (level < minLevel) level = minLevel;
            else if (level > maxLevel) level = maxLevel;
            
            setZoomTypeLevel(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],level,
            function(tabId,url)
            {
                if (zoomMode == 0 && siteZoomablePage(tabs[0].url) && !imagePage(tabs[0].id)) updateSiteZoomLevel(tabs[0].url,tabs[0].incognito,perTabZoomLevels[tabs[0].id]);
                
                updateBrowserAction(tabs[0].id,tabs[0].url,perTabZoomTypes[tabs[0].id],perTabZoomLevels[tabs[0].id],perTabFontSizes[tabs[0].id]);
                
                chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabs[0].id], zoomlevel: perTabZoomLevels[tabs[0].id] },checkError);
            });
        }
    });
}

/************************************************************************/

/* Utility functions */

function checkZoomSettings()  /* Firefox - workaround until chrome.tabs.setZoomSettings supports changing scope */  /*???*/
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        chrome.tabs.getZoomSettings(tabs[0].id,
        function(zoomSettings)
        {
            if (zoomSettings.scope == "per-origin" && (zoomMode == 1 || allowSubsites))
            {
                alertNotify("To allow per-tab or per-subsite zoom:\n\n" +
                            "Set 'browser.zoom.siteSpecific' to 'false'\n" +
                            "in Firefox's 'about:config' preferences.");
            }
        });
    });
}

function definePerTabValues(tabId,url)
{
    if (zoomMode == 0 && siteZoomablePage(url) && !imagePage(tabId))  /* Per-Site */
    {
        perTabZoomTypes[tabId] = getSiteZoomType(url);
        
        if (hasSiteZoomLevel(url)) perTabZoomLevels[tabId] = getSiteZoomLevel(url);
        else if (typeof perTabZoomLevels[tabId] == "undefined") perTabZoomLevels[tabId] = (getSiteZoomType(url) == 0) ? defaultFullLevel : defaultTextLevel;
        
        perTabFontSizes[tabId] = getSiteFontSize(url);
    }
    else  /* Per-Tab */
    {
        if (typeof perTabZoomTypes[tabId] == "undefined") perTabZoomTypes[tabId] = (!scriptablePage(url)) ? 0 : defaultType;
        else perTabZoomTypes[tabId] = (!scriptablePage(url)) ? 0 : perTabZoomTypes[tabId];
        
        if (typeof perTabZoomLevels[tabId] == "undefined") perTabZoomLevels[tabId] = (((!scriptablePage(url)) ? 0 : defaultType) == 0) ? defaultFullLevel : defaultTextLevel;
        
        if (typeof perTabFontSizes[tabId] == "undefined") perTabFontSizes[tabId] = (!scriptablePage(url)) ? 0 : defaultSize;
        else perTabFontSizes[tabId] = (!scriptablePage(url)) ? 0 : perTabFontSizes[tabId];
    }
}

function changeFullZoomMethod()
{
    chrome.tabs.query({ },
    function(tabs)
    {
        var i;
        
        for (i = 0; i < tabs.length; i++)
        {
            definePerTabValues(tabs[i].id,tabs[i].url);  /* in case undefined */
            
            if (zoomablePage(tabs[i].url))
            {
                setZoomTypeLevel(tabs[i].id,tabs[i].url,perTabZoomTypes[tabs[i].id],perTabZoomLevels[tabs[i].id],
                function(tabId,url)
                {
                    updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                    
                    if (tabId == activeTabId)
                    {
                        chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabId], zoomlevel: perTabZoomLevels[tabId] },checkError);
                        
                        chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabId] },checkError);
                    }
                });
            }
        }
    });
}

function zoomablePage(url)
{
    /* Can (and should) browser apply Full Zoom to this page ? */
    /* Chrome - scriptable pages */
    /* Firefox - all pages - except for a few pages that should not be zoomed */
    
    if (siteZoomablePage(url)) return true;
    
    if (isFirefox)
    {
        if (perTabZoomTypes[activeTabId] == 0 && !cssFullZoom)  /* browser full zoom */
        {
            if (url.substr(0,11) != "about:blank" &&
                url.substr(0,9) != "resource:") return true;
        }
    }
    
    return false;
}

function siteZoomablePage(url)
{
    /* Can (and should) browser apply Per-Site Full Zoom to this page ? */
    /* Chrome - scriptable pages */
    /* Firefox - scriptable, https://addons.mozilla.org and about: pages */
    
    if (scriptablePage(url)) return true;
    
    if (isFirefox)
    {
        if (perTabZoomTypes[activeTabId] == 0 && !cssFullZoom)  /* browser full zoom */
        {
            if (url.substr(0,26) == "https://addons.mozilla.org" ||
                url.substr(0,14) == "moz-extension:" ||
                (url.substr(0,6) == "about:" && url.substr(0,11) != "about:blank")) return true;
        }
    }
    
    return false;
}

function scriptablePage(url)
{
    /* Can content script be loaded into this page ? */
    /* Content script is required for Minimum Font Size, AutoFit, CSS Full Zoom and Text Zoom */
    /* Chrome & Firefox - http:, https: and file: pages - except for a few pages where content script cannot or should not be loaded */
    
    if (isFirefox)
    {
        if ((url.substr(0,5) == "http:" || url.substr(0,6) == "https:" || url.substr(0,5) == "file:") &&
            url.substr(0,26) != "https://addons.mozilla.org") return true;
    }
    else /* Chrome */
    {
        if ((url.substr(0,5) == "http:" || url.substr(0,6) == "https:" || url.substr(0,5) == "file:") &&
            url.substr(0,34) != "https://chrome.google.com/webstore" &&
            (url.substr(0,19) != "https://www.google." || url.indexOf("/_/chrome/newtab") < 0) &&
            (url.substr(0,19) != "https://www.google." || url.indexOf("sourceid=chrome-instant") < 0)) return true;
    }
    
    return false;
}

function imagePage(tabId)
{
    if (typeof perTabContentTypes[tabId] == "undefined") return false;
    
    if (perTabContentTypes[tabId] == null) return false;
    
    if (perTabContentTypes[tabId].substr(0,5) == "image") return true;
    
    return false;
}

function setZoomTypeLevel(tabId,url,type,level,callback)
{
    var browserlevel;
    
    debugHistory += "SetZoomTypeLevel(" + tabId + ")";
    debugHistory += "[" + type + "," + level + "%]";
    debugHistory += "{" + getHost(url) + "}, ";
    
    if (typeof perTabReadyStates[tabId] == "undefined") return;  /* tab pending */
    
    if (imagePage(tabId) && perTabReadyStates[tabId] != "complete")
    {
        type = 0;
        level = 100;
    }
    
    if (zoomMode == 0 && siteZoomablePage(url) && !imagePage(tabId))  /* Per-Site */
    {
        chrome.tabs.query({ },
        function(tabs)
        {
            var i,host;
            
            /* Set CSS full zoom level and text zoom level */
            
            host = getHost(url);
            
            if (host != "")
            {
                for (i = 0; i < tabs.length; i++)
                {
                    if (getHost(tabs[i].url) == host)
                    {
                        perTabZoomTypes[tabs[i].id] = type;
                        
                        perTabZoomLevels[tabs[i].id] = level;
                        
                        if (scriptablePage(tabs[i].url) && !imagePage(tabs[i].id)) chrome.tabs.sendMessage(tabs[i].id,{ type: "setzoomtypelevel", zoomtype: type, zoomlevel: level },checkError);
                    }
                }
            }
            
            /* Set browser full zoom level */
            
            if (type == 1) browserlevel = defaultOtherLevel;
            else browserlevel = cssFullZoom ? 100 : level;
            
            chrome.tabs.getZoomSettings(tabId,
            function(zoomSettings)
            {
                var i,host,tabtotal,tabcount;
                
                if (zoomSettings.scope == "per-origin" && !allowSubsites)  /* per-site but not per-subsite */
                {
                    /* Rely on browser full zoom to apply site level to tabs with matching urls */
                    
                    chrome.tabs.getZoom(tabId,
                    function(zoomFactor)
                    {
                        if (Math.round(zoomFactor*100) != browserlevel)
                        {
                            if (resizeIgnoreTimeout != null) window.clearTimeout(resizeIgnoreTimeout);
                            resizeIgnoreTimeout = window.setTimeout(function() { resizeIgnoreTimeout = null; },200);
                            
                            chrome.tabs.setZoom(tabId,browserlevel/100,
                            function()
                            {
                                if (typeof callback != "undefined") callback(tabId,url);
                            });
                        }
                        else if (typeof callback != "undefined") callback(tabId,url);
                    });
                }
                else
                {
                    host = getHost(url);
                    
                    if (host != "")
                    {
                        if (resizeIgnoreTimeout != null) window.clearTimeout(resizeIgnoreTimeout);
                        resizeIgnoreTimeout = window.setTimeout(function() { resizeIgnoreTimeout = null; },200);
                        
                        tabtotal = 0;
                        tabcount = 0;
                        
                        for (i = 0; i < tabs.length; i++)
                        {
                            if (getHost(tabs[i].url) == host)
                            {
                                tabtotal++;
                                
                                chrome.tabs.setZoom(tabs[i].id,browserlevel/100,
                                function()
                                {
                                    if (++tabcount == tabtotal && typeof callback != "undefined")
                                    {
                                        callback(tabId,url);
                                    }
                                });
                            }
                        }
                    }
                }
            });
        });
    }
    else  /* Per-Tab */
    {
        /* Set CSS full zoom level and text zoom level */
        
        perTabZoomTypes[tabId] = type;
        
        perTabZoomLevels[tabId] = level;
        
        if (scriptablePage(url) && !imagePage(tabId)) chrome.tabs.sendMessage(tabId,{ type: "setzoomtypelevel", zoomtype: type, zoomlevel: level },checkError);
        
        /* Set browser full zoom level */
        
        if (type == 1) browserlevel = defaultOtherLevel;
        else browserlevel = cssFullZoom ? 100 : level;
        
        chrome.tabs.getZoom(tabId,
        function(zoomFactor)
        {
            if (Math.round(zoomFactor*100) != browserlevel)
            {
                if (resizeIgnoreTimeout != null) window.clearTimeout(resizeIgnoreTimeout);
                resizeIgnoreTimeout = window.setTimeout(function() { resizeIgnoreTimeout = null; },200);
                
                chrome.tabs.setZoom(tabId,browserlevel/100,
                function()
                {
                    if (typeof callback != "undefined") callback(tabId,url);
                });
            }
            else if (typeof callback != "undefined") callback(tabId,url);
        });
    }
}

function getSiteZoomType(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteZoomTypes[host] != "undefined") return perSiteZoomTypes[host];
    }
    
    return (!scriptablePage(url)) ? 0 : defaultType;
}

function getSiteZoomLevel(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteZoomLevels[host] != "undefined") return perSiteZoomLevels[host];
    }
    
    return (getSiteZoomType(url) == 0) ? defaultFullLevel : defaultTextLevel;
}

function hasSiteZoomType(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteZoomTypes[host] != "undefined") return true;
    }
    
    return false;
}

function hasSiteZoomLevel(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteZoomLevels[host] != "undefined") return true;
    }
    
    return false;
}

function clearSiteZoomType(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteZoomTypes[host] != "undefined") delete perSiteZoomTypes[host];
        if (typeof perSiteZoomTypesNotIncognito[host] != "undefined") delete perSiteZoomTypesNotIncognito[host];
        
        chrome.storage.local.set(
        {
            "persite-zoomtypes": perSiteZoomTypesNotIncognito
        });
    }
}

function clearSiteZoomLevel(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteZoomLevels[host] != "undefined") delete perSiteZoomLevels[host];
        if (typeof perSiteZoomLevelsNotIncognito[host] != "undefined") delete perSiteZoomLevelsNotIncognito[host];
        
        chrome.storage.local.set(
        {
            "persite-zoomlevels": perSiteZoomLevelsNotIncognito
        });
    }
}

function updateSiteZoomType(url,incognito,type)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        perSiteZoomTypes[host] = type;
        if (!incognito) perSiteZoomTypesNotIncognito[host] = type;
        
        chrome.storage.local.set(
        {
            "persite-zoomtypes": perSiteZoomTypesNotIncognito
        });
    }
}

function updateSiteZoomLevel(url,incognito,level)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        perSiteZoomLevels[host] = level;
        if (!incognito) perSiteZoomLevelsNotIncognito[host] = level;
        
        chrome.storage.local.set(
        {
            "persite-zoomlevels": perSiteZoomLevelsNotIncognito
        });
    }
}

function setFontSize(tabId,url,size,callback)
{
    debugHistory += "SetFontSize(" + tabId + ")";
    debugHistory += "[" + size + "px]";
    debugHistory += "{" + getHost(url) + "}, ";
    
    if (typeof perTabReadyStates[tabId] == "undefined") return;  /* tab pending */
    
    if (imagePage(tabId) && perTabReadyStates[tabId] != "complete")
    {
        size = 0;
    }
    
    if (zoomMode == 0 && siteZoomablePage(url) && !imagePage(tabId))  /* Per-Site */
    {
        chrome.tabs.query({ },
        function(tabs)
        {
            var i,host;
            
            host = getHost(url);
            
            if (host != "")
            {
                for (i = 0; i < tabs.length; i++)
                {
                    if (getHost(tabs[i].url) == host)
                    {
                        perTabFontSizes[tabs[i].id] = size;
                        
                        if (scriptablePage(tabs[i].url) && !imagePage(tabs[i].id)) chrome.tabs.sendMessage(tabs[i].id,{ type: "setfontsize", fontsize: size },checkError);
                    }
                }
            }
            
            if (typeof callback != "undefined") callback(tabId,url);  /* may need to delay */
        });
    }
    else  /* Per-Tab */
    {
        perTabFontSizes[tabId] = size;
        
        if (scriptablePage(url) && !imagePage(tabId)) chrome.tabs.sendMessage(tabId,{ type: "setfontsize", fontsize: size },checkError);
        
        if (typeof callback != "undefined") callback(tabId,url);  /* may need to delay */
    }
}

function getSiteFontSize(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteFontSizes[host] != "undefined") return perSiteFontSizes[host];
    }
    
    return (!scriptablePage(url)) ? 0 : defaultSize;
}

function hasSiteFontSize(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteFontSizes[host] != "undefined") return true;
    }
    
    return false;
}

function clearSiteFontSize(url)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        if (typeof perSiteFontSizes[host] != "undefined") delete perSiteFontSizes[host];
        if (typeof perSiteFontSizesNotIncognito[host] != "undefined") delete perSiteFontSizesNotIncognito[host];
        
        chrome.storage.local.set(
        {
            "persite-fontsizes": perSiteFontSizesNotIncognito
        });
    }
}

function updateSiteFontSize(url,incognito,size)
{
    var host;
    
    host = getHost(url);
    
    if (host != "")
    {
        perSiteFontSizes[host] = size;
        if (!incognito) perSiteFontSizesNotIncognito[host] = size;
        
        chrome.storage.local.set(
        {
            "persite-fontsizes": perSiteFontSizesNotIncognito
        });
    }
}

function getSubsiteType(url)
{
    var hostpath;
    
    if (url.substr(0,5) == "http:" || url.substr(0,6) == "https:")
    {
        if (allowSubsites)
        {
            try
            {
                hostpath = new URL(url).hostname + new URL(url).pathname;
                
                if (hostpath.substr(-1) == "/") hostpath = hostpath.substr(0,hostpath.length-1);
                
                if (typeof subsiteTypes[hostpath] != "undefined") return subsiteTypes[hostpath];
            }
            catch (e) { }
        }
    }
    
    return 0;
}

function hasSubSiteType(url)
{
    var hostpath;
    
    if (url.substr(0,5) == "http:" || url.substr(0,6) == "https:")
    {
        if (allowSubsites)
        {
            try
            {
                hostpath = new URL(url).hostname + new URL(url).pathname;
                
                if (hostpath.substr(-1) == "/") hostpath = hostpath.substr(0,hostpath.length-1);
                
                if (typeof subsiteTypes[hostpath] != "undefined") return true;
            }
            catch (e) { }
        }
    }
    
    return false;
}

function clearSubsiteType(url)
{
    var hostpath;
    
    if (url.substr(0,5) == "http:" || url.substr(0,6) == "https:")
    {
        if (allowSubsites)
        {
            try
            {
                hostpath = new URL(url).hostname + new URL(url).pathname;
                
                if (hostpath.substr(-1) == "/") hostpath = hostpath.substr(0,hostpath.length-1);
                
                if (typeof subsiteTypes[hostpath] != "undefined") delete subsiteTypes[hostpath];
                if (typeof subsiteTypesNotIncognito[hostpath] != "undefined") delete subsiteTypesNotIncognito[hostpath];
                
                chrome.storage.local.set(
                {
                    "subsite-types": subsiteTypesNotIncognito
                });
            }
            catch (e) { }
        }
        
    }
}

function updateSubsiteType(url,incognito,type)
{
    var hostpath;
    
    if (url.substr(0,5) == "http:" || url.substr(0,6) == "https:")
    {
        if (allowSubsites)
        {
            try
            {
                hostpath = new URL(url).hostname + new URL(url).pathname;
                
                if (hostpath.substr(-1) == "/") hostpath = hostpath.substr(0,hostpath.length-1);
                
                subsiteTypes[hostpath] = type;
                if (!incognito) subsiteTypesNotIncognito[hostpath] = type;
                
                chrome.storage.local.set(
                {
                    "subsite-types": subsiteTypesNotIncognito
                });
            }
            catch (e) { }
        }
    }
}

function getHost(url)
{
    var host,maxlength,hostpath,subsite;
    var hostpathsegments = new Array();
    var subsitesegments = new Array();
    
    if (url.substr(0,14) == "moz-extension:") host = url;
    else if (url.substr(0,6) == "about:") host = url;
    else if (url.substr(0,5) == "file:") host = url;
    else if (url.substr(0,5) == "http:" || url.substr(0,6) == "https:")
    {
        try
        {
            host = new URL(url).hostname;
            
            if (allowSubsites)
            {
                maxlength = 0;
                
                hostpath = new URL(url).hostname + new URL(url).pathname;
                
                if (hostpath.substr(-1) == "/") hostpath = hostpath.substr(0,hostpath.length-1);
                
                hostpathsegments = hostpath.split("/");
                
                for (subsite in subsiteTypes)
                {
                    if (subsiteTypes.hasOwnProperty(subsite))
                    {
                        if (subsite.length > maxlength)
                        {
                            subsitesegments = subsite.split("/");
                            
                            if (hostpath.indexOf(subsite) == 0 && hostpathsegments.length-subsitesegments.length > subsiteTypes[subsite]-2)
                            {
                                host = "subsite:" + subsite;
                                maxlength = subsite.length;
                            }
                        }
                    }
                }
            }
        }
        catch (e) { host = ""; }
    }
    else host = "";
    
    return host;
}

function webNavigationLoading(tabId,url,complete)
{
    if (isFirefox) _webNavigationLoading();
    else chrome.tabs.setZoomSettings(tabId,{ mode: "automatic", scope: "per-tab" },_webNavigationLoading);
    
    function _webNavigationLoading()
    {
        if (zoomablePage(url))
        {
            if (zoomMode == 0 && siteZoomablePage(url) && !imagePage(tabId))  /* Per-Site */
            {
                if (applyAutoFit && scriptablePage(url) && !hasSiteZoomLevel(url) && !imagePage(tabId))
                {
                    if (getHost(url) != "" && getHost(url) != perTabAutoFitHosts[tabId])  /* perTabAutoFitHosts is undefined or null or different host */
                    {
                        if (complete)
                        {
                            perTabAutoFitHosts[tabId] = getHost(url);
                            
                            chrome.tabs.sendMessage(tabId,{ type: "autofitstart", setsite: false },{ frameId: 0 },checkError);
                        }
                    }
                }
                else
                {
                    perTabAutoFitHosts[tabId] = null;
                    
                    setZoomTypeLevel(tabId,url,getSiteZoomType(url),getSiteZoomLevel(url),
                    function(tabId,url)
                    {
                        updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                        
                        if (tabId == activeTabId)
                        {
                            chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabId], zoomlevel: perTabZoomLevels[tabId] },checkError);
                        }
                    });
                }
                
                setFontSize(tabId,url,getSiteFontSize(url),
                function(tabId,url)  /* called even if not scriptable page */
                {
                    updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                    
                    chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabId] },checkError);
                });
            }
            else  /* Per-Tab */
            {
                if (applyAutoFit && scriptablePage(url) && !imagePage(tabId))
                {
                    if (getHost(url) != "" && getHost(url) != perTabAutoFitHosts[tabId])  /* perTabAutoFitHosts is undefined or null or different host */
                    {
                        if (complete)
                        {
                            perTabAutoFitHosts[tabId] = getHost(url);
                            
                            chrome.tabs.sendMessage(tabId,{ type: "autofitstart", setsite: false },{ frameId: 0 },checkError);
                        }
                    }
                }
                else
                {
                    perTabAutoFitHosts[tabId] = null;
                    
                    setZoomTypeLevel(tabId,url,perTabZoomTypes[tabId],(resetOnLoad) ? ((perTabZoomTypes[tabId] == 0) ? defaultFullLevel : defaultTextLevel) : perTabZoomLevels[tabId],
                    function(tabId,url)  /* called even if not scriptable page */
                    {
                        updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                        
                        if (tabId == activeTabId)
                        {
                            chrome.runtime.sendMessage({ type: "newzoomtypelevel", zoomtype: perTabZoomTypes[tabId], zoomlevel: perTabZoomLevels[tabId] },checkError);
                        }
                    });
                }
                
                setFontSize(tabId,url,(resetOnLoad) ? defaultSize : perTabFontSizes[tabId],
                function(tabId,url)
                {
                    updateBrowserAction(tabId,url,perTabZoomTypes[tabId],perTabZoomLevels[tabId],perTabFontSizes[tabId]);
                    
                    chrome.runtime.sendMessage({ type: "newfontsize", fontsize: perTabFontSizes[tabId] },checkError);
                });
            }
        }
    }
}

function handleBrowserResize(tabId,url)
{
    if (resizeIgnoreTimeout != null) return;  /* ignore resizes for short period after chrome.tabs.setZoom() */
    
    if (resizeFinishTimeout != null) window.clearTimeout(resizeFinishTimeout);  /* to update zoom at end of resize */
   
    resizeFinishTimeout = window.setTimeout(
    function(tabId,url)
    {
        var complete;
        
        resizeFinishTimeout = null;
        
        complete = (typeof perTabReadyStates[tabId] != "undefined" && perTabReadyStates[tabId] == "complete");
        
        if (zoomMode == 0 && siteZoomablePage(url) && !imagePage(tabId))  /* Per-Site */
        {
            if (applyAutoFit && scriptablePage(url) && !hasSiteZoomLevel(url) && !imagePage(tabId))
            {
                if (complete)
                {
                    perTabAutoFitHosts[tabId] = getHost(url);
                    
                    chrome.tabs.sendMessage(tabId,{ type: "autofitstart", setsite: false },{ frameId: 0 },checkError);
                }
            }
        }
        else  /* Per-Tab */
        {
            if (applyAutoFit && scriptablePage(url) && !imagePage(tabId))
            {
                if (complete)
                {
                    perTabAutoFitHosts[tabId] = getHost(url);
                    
                    chrome.tabs.sendMessage(tabId,{ type: "autofitstart", setsite: false },{ frameId: 0 },checkError);
                }
            }
        }
    },100,tabId,url);
}

function updateBrowserAction(tabId,url,type,level,size)
{
    if (type == 0) chrome.browserAction.setTitle({ tabId: tabId, title: "Zoom Page WE - Full Zoom " + level + "% - Min Font " + size + "px" });
    else chrome.browserAction.setTitle({ tabId: tabId, title: "Zoom Page WE - Text Zoom " + level + "% - Min Font " + size + "px" });
    
    if (showBadge)
    {
        if (level >= 100) chrome.browserAction.setBadgeText({ tabId: tabId, text: "" + level + "" });
        else chrome.browserAction.setBadgeText({ tabId: tabId, text: " " + level + " " });
        
        if (type == 0) chrome.browserAction.setBadgeBackgroundColor({ tabId: tabId, color: "#4040C0" });
        else chrome.browserAction.setBadgeBackgroundColor({ tabId: tabId, color: "#C02020" });
        
        if (size == 0)
        {
            if (hasSubSiteType(url)) chrome.browserAction.setIcon({ tabId: tabId, path: (isFirefox) ? "icon16-mfsoff-sson-MF.png" : "icon16-mfsoff-sson-GC.png" });
            else chrome.browserAction.setIcon({ tabId: tabId, path: (isFirefox) ? "icon16-mfsoff-ssoff-MF.png" : "icon16-mfsoff-ssoff-GC.png" });
        }
        else
        {
            if (hasSubSiteType(url)) chrome.browserAction.setIcon({ tabId: tabId, path: (isFirefox) ? "icon16-mfson-sson-MF.png" : "icon16-mfson-sson-GC.png" });
            else chrome.browserAction.setIcon({ tabId: tabId, path: (isFirefox) ? "icon16-mfson-ssoff-MF.png" : "icon16-mfson-ssoff-GC.png" });
        }
    }
    else
    {
        chrome.browserAction.setBadgeText({ tabId: tabId, text: "" });
        chrome.browserAction.setIcon({ tabId: tabId, path: "icon16.png"});
    }
}

/************************************************************************/

/* Check for sendMessage errors */

function checkError()
{
    if (chrome.runtime.lastError == null) ;
    else if (chrome.runtime.lastError.message == "Could not establish connection. Receiving end does not exist.") ;  /* Chrome & Firefox - ignore */
    else if (chrome.runtime.lastError.message == "The message port closed before a response was received.") ;  /* Chrome - ignore */
    else if (chrome.runtime.lastError.message == "Message manager disconnected") ;  /* Firefox - ignore */
    else console.log("Zoom Page WE - " + chrome.runtime.lastError.message);
}

/************************************************************************/

/* Display alert notification */

function alertNotify(message)
{
    chrome.notifications.create("alert",{ type: "basic", iconUrl: "icon32.png", title: "ZOOM PAGE WE", message: "" + message });
}

/************************************************************************/

/* Display debug notification */

function debugNotify(message)
{
    chrome.notifications.create("debug",{ type: "basic", iconUrl: "icon32.png", title: "ZOOM PAGE WE - DEBUG", message: "" + message });
}

/************************************************************************/
