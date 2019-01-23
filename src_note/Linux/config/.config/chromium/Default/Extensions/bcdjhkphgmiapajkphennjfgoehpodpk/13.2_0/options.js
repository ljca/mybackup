/************************************************************************/
/*                                                                      */
/*      Zoom Page WE - Generic WebExtension - Options Page              */
/*                                                                      */
/*      Javascript for Options Page                                     */
/*                                                                      */
/*      Last Edit - 30 Nov 2018                                         */
/*                                                                      */
/*      Copyright (C) 2016-2018 DW-dev                                  */
/*                                                                      */
/*      Distributed under the GNU General Public License version 2      */
/*      See LICENCE.txt file and http://www.gnu.org/licenses/           */
/*                                                                      */
/************************************************************************/

/************************************************************************/
/*                                                                      */
/*  Refer to Google Chrome developer documentation:                     */
/*                                                                      */
/*  https://developer.chrome.com/extensions/optionsV2                   */
/*                                                                      */
/*  https://developer.chrome.com/extensions/storage                     */
/*                                                                      */
/************************************************************************/

"use strict";

/************************************************************************/

/* Global variables */

var isFirefox;
var ffVersion;

var chromeLevels = "25 33 50 67 75 80 90 100 110 125 150 175 200 250 300 400 500";
var firefoxLevels = "30 50 67 80 90 100 110 120 133 150 170 200 240 300";

/************************************************************************/

/* Listener for options page load */

document.addEventListener("DOMContentLoaded",onLoadPage,false);

/************************************************************************/

/* Initialize on page load */

function onLoadPage(event)
{
    /* Load options from local storage */
    
    chrome.storage.local.get(null,
    function(object)
    {
        /* Load environment */
        
        isFirefox = object["environment-isfirefox"];
        
        if (isFirefox) ffVersion = object["environment-ffversion"];
	    
        if (isFirefox) document.body.setAttribute("firefox","");
        
        if (isFirefox && ffVersion >= 60) document.body.setAttribute("shortcuts","");
        
        /* General options */
        
        document.getElementById("options-zoommode").elements["mode"].value = object["options-zoommode"];
        document.getElementById("options-resetonload").checked = object["options-resetonload"];
        document.getElementById("options-cssfullzoom").checked = object["options-cssfullzoom"];
        document.getElementById("options-applyautofit").checked = object["options-applyautofit"];
        document.getElementById("options-allowsubsites").checked = object["options-allowsubsites"];
        
        document.getElementById("options-zoomtype").elements["type"].value = object["options-defaulttype"];
        
        document.getElementById("options-enablescaling").checked = object["options-enablescaling"];
        document.getElementById("options-applyscaling").checked = object["options-applyscaling"];
        
        document.getElementById("options-showbadge").checked = object["options-showbadge"];
        document.getElementById("options-showsubmenu").checked = object["options-showsubmenu"];
        document.getElementById("options-enablectrl789").checked = object["options-enablectrl789"];
        document.getElementById("options-enablerightwheel").checked = object["options-enablerightwheel"];
        
        document.getElementById("options-resetonload").disabled = document.getElementById("options-persite").checked;
        document.getElementById("options-allowsubsites").disabled = !document.getElementById("options-persite").checked;
        document.getElementById("options-applyscaling").disabled = !document.getElementById("options-enablescaling").checked;
        
        /* Zoom Levels & Font Size options */
        
        document.getElementById("options-zoomlevels").value = object["options-zoomlevels"].join(" ");
        
        document.getElementById("options-defaultfulllevel").value = object["options-defaultfulllevel"];
        document.getElementById("options-defaulttextlevel").value = object["options-defaulttextlevel"];
        document.getElementById("options-defaultotherlevel").value = object["options-defaultotherlevel"];
        document.getElementById("options-autominlevel").value = object["options-autominlevel"];
        document.getElementById("options-automaxlevel").value = object["options-automaxlevel"];
        
        document.getElementById("options-zoominout").elements["inout"].value = object["options-zoominout"];
        document.getElementById("options-zoomstep").value = object["options-zoomstep"];
        
        document.getElementById("options-defaultsize").value = object["options-defaultsize"];
        document.getElementById("options-adjustlinespace").checked = object["options-adjustlinespace"];
        document.getElementById("options-linespacefactor").value = object["options-linespacefactor"];
        
        document.getElementById("options-applytodynamic").checked = object["options-applytodynamic"];
        
        document.getElementById("options-zoomstep").disabled = document.getElementById("options-nextlevel").checked;
        document.getElementById("options-linespacefactor").disabled = !document.getElementById("options-adjustlinespace").checked;
        
        /* Keyboard shortcuts */
        
        if (isFirefox && ffVersion >= 60)
        {
            chrome.commands.getAll(
            function(commands)
            {
                var i;
                
                for (i = 0; i < commands.length; i++)
                {
                    if (commands[i].name == "_execute_browser_action") document.getElementById("options-shortcuts-browseraction").value = commands[i].shortcut;
                }
            });
        }
    });
    
    /* Add listeners for click on tab buttons */
    
    document.getElementById("options-tabbar-general").addEventListener("click",showGeneralTab,false);
    document.getElementById("options-tabbar-zoomlevels").addEventListener("click",showZoomLevelsTab,false);
    document.getElementById("options-tabbar-shortcuts").addEventListener("click",showShortcutsTab,false);
    
    /* Add listeners for click on per-site and per-tab radio buttons */
    
    document.getElementById("options-persite").addEventListener("click",onClickZoomMode,false);
    document.getElementById("options-pertab").addEventListener("click",onClickZoomMode,false);
    
    /* Add listener for click on allow subsites checkbox */
    
    document.getElementById("options-allowsubsites").addEventListener("click",onClickAllowSubsites,false);
    
    /* Add listener for click on enable scaling checkbox */
    
    document.getElementById("options-enablescaling").addEventListener("click",onClickEnableScaling,false);
    
    /* Add listeners for click on next-level and fixed-step radio buttons */
    
    document.getElementById("options-nextlevel").addEventListener("click",onClickZoomInOut,false);
    document.getElementById("options-fixedstep").addEventListener("click",onClickZoomInOut,false);
    
    /* Add listener for click on apply line space checkbox */
    
    document.getElementById("options-adjustlinespace").addEventListener("click",onClickAdjustLineSpace,false);
    
    /* Add listener for click on save button */
    
    document.getElementById("options-save-button").addEventListener("click",onClickSave,false);
    
    /* Add listener for click on reset all button */
    
    document.getElementById("options-resetall-button").addEventListener("click",onClickResetAll,false);
    
    /* Add listener for click on clear all button */
    
    document.getElementById("options-clearall-button").addEventListener("click",onClickClearAll,false);
    
    /* Wait for page layout to complete */
    
    document.getElementById("options").style.setProperty("opacity","0","");
    
    window.setTimeout(
    function()
    {
        var width1,width2,width3,height1,height2,height3;
        
        /* Equalize widths of tabs */
        
        width1 = window.getComputedStyle(document.getElementById("options-tab-general"),null).getPropertyValue("width");
        width2 = window.getComputedStyle(document.getElementById("options-tab-zoomlevels"),null).getPropertyValue("width");
        width3 = window.getComputedStyle(document.getElementById("options-tab-shortcuts"),null).getPropertyValue("width");
        
        width1 = width1.substr(0,width1.length-2);
        width2 = width2.substr(0,width2.length-2);
        width3 = width3.substr(0,width3.length-2);
        
        width1 = Math.max(width1,width2,width3);
        
        document.getElementById("options-tab-general").style.setProperty("width",width1 + "px","");
        document.getElementById("options-tab-zoomlevels").style.setProperty("width",width1 + "px","");
        
        /* Equalize heights of tabs */
        
        height1 = window.getComputedStyle(document.getElementById("options-tab-general"),null).getPropertyValue("height");
        height2 = window.getComputedStyle(document.getElementById("options-tab-zoomlevels"),null).getPropertyValue("height");
        height3 = window.getComputedStyle(document.getElementById("options-tab-shortcuts"),null).getPropertyValue("height");
        
        height1 = height1.substr(0,height1.length-2);
        height2 = height2.substr(0,height2.length-2);
        height3 = height3.substr(0,height3.length-2);
        
        height1 = Math.max(height1,height2,height3);
        
        document.getElementById("options-tab-general").style.setProperty("height",height1 + "px","");
        document.getElementById("options-tab-zoomlevels").style.setProperty("height",height1 + "px","");
        document.getElementById("options-tab-shortcuts").style.setProperty("height",height1 + "px","");
        
        /* Show general tab */
        
        showGeneralTab();
        
        document.getElementById("options").style.setProperty("opacity","1","");
    },50);
}


/************************************************************************/

/* Select tab */

function showGeneralTab(event)
{
    document.getElementById("options-tabbar-general").setAttribute("selected","");
    document.getElementById("options-tabbar-zoomlevels").removeAttribute("selected");
    document.getElementById("options-tabbar-shortcuts").removeAttribute("selected");
    
    document.getElementById("options-tab-general").style.setProperty("display","block","");
    document.getElementById("options-tab-zoomlevels").style.setProperty("display","none","");
    document.getElementById("options-tab-shortcuts").style.setProperty("display","none","");
}

function showZoomLevelsTab(event)
{
    document.getElementById("options-tabbar-general").removeAttribute("selected");
    document.getElementById("options-tabbar-zoomlevels").setAttribute("selected","");
    document.getElementById("options-tabbar-shortcuts").removeAttribute("selected");
    
    document.getElementById("options-tab-general").style.setProperty("display","none","");
    document.getElementById("options-tab-zoomlevels").style.setProperty("display","block","");
    document.getElementById("options-tab-shortcuts").style.setProperty("display","none","");
}

function showShortcutsTab(event)
{
    document.getElementById("options-tabbar-general").removeAttribute("selected");
    document.getElementById("options-tabbar-zoomlevels").removeAttribute("selected");
    document.getElementById("options-tabbar-shortcuts").setAttribute("selected","");
    
    document.getElementById("options-tab-general").style.setProperty("display","none","");
    document.getElementById("options-tab-zoomlevels").style.setProperty("display","none","");
    document.getElementById("options-tab-shortcuts").style.setProperty("display","block","");
}

/************************************************************************/

/* Enable or Disable options */

function onClickZoomMode(event)
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        chrome.tabs.getZoomSettings(tabs[0].id,
        function(zoomSettings)
        {
            /* Check Firefox browser.zoom.siteSpecific preference is correctly set */
            
            if (isFirefox)
            {
                if (zoomSettings.scope == "per-origin" && document.getElementById("options-pertab").checked)
                {
                    document.getElementById("options-zoommode").elements["mode"].value = 0;
                    
                    alert("To allow per-tab zoom:\n\n" +
                          "Set 'browser.zoom.siteSpecific' to 'false'\n" +
                          "in Firefox's 'about:config' preferences.\n\n");
                }
            }
            
            document.getElementById("options-resetonload").disabled = document.getElementById("options-persite").checked;
            document.getElementById("options-allowsubsites").disabled = !document.getElementById("options-persite").checked;
        });
    });
}

function onClickAllowSubsites(event)
{
    chrome.tabs.query({ lastFocusedWindow: true, active: true },
    function(tabs)
    {
        chrome.tabs.getZoomSettings(tabs[0].id,
        function(zoomSettings)
        {
            /* Check Firefox browser.zoom.siteSpecific preference is correctly set */
            
            if (isFirefox)
            {
                if (zoomSettings.scope == "per-origin" && document.getElementById("options-allowsubsites").checked)
                {
                    document.getElementById("options-allowsubsites").checked = false;
                    
                    alert("To allow per-subsite zoom:\n\n" +
                          "Set 'browser.zoom.siteSpecific' to 'false'\n" +
                          "in Firefox's 'about:config' preferences.\n\n");
                }
            }
        });
    });
}

function onClickEnableScaling(event)
{
    document.getElementById("options-applyscaling").disabled = !document.getElementById("options-enablescaling").checked;
}

function onClickZoomInOut(event)
{
    document.getElementById("options-zoomstep").disabled = document.getElementById("options-nextlevel").checked;
}

function onClickAdjustLineSpace(event)
{
    document.getElementById("options-linespacefactor").disabled = !document.getElementById("options-adjustlinespace").checked;
}

/************************************************************************/

/* Save options */

function onClickSave(event)
{
    var i,list,level,step,size;
    var levels = new Array();
    
    /* Validate zoom levels */
    
    list = document.getElementById("options-zoomlevels").value;
    
    list = list.replace(/[^0-9 ]/g,"");
    list = list.replace(/ +/g," ");
    list = list.replace(/^ +/g,"");
    list = list.replace(/ +$/g,"");
    
    levels = list.split(" ");
    
    for (i = 0; i < levels.length; i++) levels[i] = levels[i].replace(/^0+/g,"");
    
    levels.sort(function(a,b){ return a-b; });
    
    for (i = 0; i < levels.length; i++) if (i > 0 && levels[i] == levels[i-1]) { levels.splice(i,1); i--; }
    
    if (levels[0] == "") list = "100"
    else list = levels.join(" ");
    
    document.getElementById("options-zoomlevels").value = list;
    
    for (i = 0; i < levels.length; i++) levels[i] = +levels[i];
    
    /* Validate other fields */
    
    level = document.getElementById("options-defaultfulllevel").value.replace(/[^0-9]/g,"");
    if (+level == 0) level = "100";
    document.getElementById("options-defaultfulllevel").value = level;
    
    level = document.getElementById("options-defaulttextlevel").value.replace(/[^0-9]/g,"");
    if (+level == 0) level = "100";
    document.getElementById("options-defaulttextlevel").value = level;
    
    level = document.getElementById("options-defaultotherlevel").value.replace(/[^0-9]/g,"");
    if (+level == 0) level = "100";
    document.getElementById("options-defaultotherlevel").value = level;
    
    level = document.getElementById("options-autominlevel").value.replace(/[^0-9]/g,"");
    if (+level == 0) level = "67";
    document.getElementById("options-autominlevel").value = level;
    
    level = document.getElementById("options-automaxlevel").value.replace(/[^0-9]/g,"");
    if (+level == 0) level = "150";
    document.getElementById("options-automaxlevel").value = level;
    
    step = document.getElementById("options-zoomstep").value.replace(/[^0-9]/g,"");
    if (+step == 0) step = "10";
    document.getElementById("options-zoomstep").value = step;
    
    size = document.getElementById("options-defaultsize").value.replace(/[^0-9]/g,"");
    if (+size == 0) size = "0";
    document.getElementById("options-defaultsize").value = size;
    
    /* Save options to local storage */
    
    chrome.storage.local.set(
    {
        /* General options */
        
        "options-zoommode": +document.getElementById("options-zoommode").elements["mode"].value,
        "options-resetonload": document.getElementById("options-resetonload").checked,
        "options-cssfullzoom": document.getElementById("options-cssfullzoom").checked,
        "options-applyautofit": document.getElementById("options-applyautofit").checked,
        "options-allowsubsites": document.getElementById("options-allowsubsites").checked,
        
        "options-defaulttype": +document.getElementById("options-zoomtype").elements["type"].value,
        
        "options-enablescaling": document.getElementById("options-enablescaling").checked,
        "options-applyscaling": document.getElementById("options-applyscaling").checked,
        
        "options-zoomlevels": levels,
        
        "options-showbadge": document.getElementById("options-showbadge").checked,
        "options-showsubmenu": document.getElementById("options-showsubmenu").checked,
        "options-enablectrl789": document.getElementById("options-enablectrl789").checked,
        "options-enablerightwheel": document.getElementById("options-enablerightwheel").checked,
        
        /* Zoom Levels & Font Size options */
        
        "options-defaultfulllevel": +document.getElementById("options-defaultfulllevel").value,
        "options-defaulttextlevel": +document.getElementById("options-defaulttextlevel").value,
        "options-defaultotherlevel": +document.getElementById("options-defaultotherlevel").value,
        "options-autominlevel": +document.getElementById("options-autominlevel").value,
        "options-automaxlevel": +document.getElementById("options-automaxlevel").value,
        
        "options-zoominout": +document.getElementById("options-zoominout").elements["inout"].value,
        "options-zoomstep": +document.getElementById("options-zoomstep").value,
        
        "options-defaultsize": +document.getElementById("options-defaultsize").value,
        "options-adjustlinespace": document.getElementById("options-adjustlinespace").checked,
        "options-linespacefactor": +document.getElementById("options-linespacefactor").value,
        
        "options-applytodynamic": document.getElementById("options-applytodynamic").checked
    });
    
    /* Keyboard shortcuts */
    
    if (isFirefox && ffVersion >= 60)
    {
        try
        {
            chrome.commands.update({ name: "_execute_browser_action", shortcut: document.getElementById("options-shortcuts-browseraction").value });
        }
        catch (e)
        {
            chrome.commands.reset("_execute_browser_action");
            document.getElementById("options-shortcuts-browseraction").value = "Alt+Z";
        }
    }
    
    /* Display saved status for short period */
    
    document.getElementById("options-save-button").innerText = "Saved";
    document.getElementById("options-save-button").style.setProperty("font-weight","bold","");
    
    setTimeout(function()
    {
        document.getElementById("options-save-button").innerText = "Save";
        document.getElementById("options-save-button").style.setProperty("font-weight","normal","");
    }
    ,1000);
}

/************************************************************************/

/* Reset All options */

function onClickResetAll(event)
{
    /* General options */
    
    document.getElementById("options-zoommode").elements["mode"].value = 0;
    document.getElementById("options-resetonload").checked = isFirefox ? false : true;
    document.getElementById("options-cssfullzoom").checked = isFirefox ? false : true;
    document.getElementById("options-applyautofit").checked = false;
    document.getElementById("options-allowsubsites").checked = false;
    
    document.getElementById("options-zoomtype").elements["type"].value = 0;
    
    document.getElementById("options-enablescaling").checked = true;
    document.getElementById("options-applyscaling").checked = false;
    
    document.getElementById("options-showbadge").checked = true;
    document.getElementById("options-showsubmenu").checked = true;
    document.getElementById("options-enablectrl789").checked = true;
    document.getElementById("options-enablerightwheel").checked = true;
    
    document.getElementById("options-resetonload").disabled = true;
    document.getElementById("options-applyscaling").disabled = false;
    
    /* Zoom Levels & Font Size options */
    
    document.getElementById("options-zoomlevels").value = isFirefox ? firefoxLevels : chromeLevels;
    
    document.getElementById("options-defaultfulllevel").value = 100;
    document.getElementById("options-defaulttextlevel").value = 100;
    document.getElementById("options-defaultotherlevel").value = 100;
    document.getElementById("options-autominlevel").value = 67;
    document.getElementById("options-automaxlevel").value = 150;
    
    document.getElementById("options-zoominout").elements["inout"].value = 0;
    document.getElementById("options-zoomstep").value = 10;
    
    document.getElementById("options-defaultsize").value = 0;
    document.getElementById("options-adjustlinespace").checked = false;
    document.getElementById("options-linespacefactor").value = 1.2;
    
    document.getElementById("options-applytodynamic").checked = true;
    
    document.getElementById("options-zoomstep").disabled = true;
    document.getElementById("options-linespacefactor").disabled = true;
        
    /* Keyboard shortcuts */
    
    if (isFirefox && ffVersion >= 60)
    {
        document.getElementById("options-shortcuts-browseraction").value = "Alt+Z";
    }
    
    /* Display reset status for short period */
    
    document.getElementById("options-resetall-button").innerText = "Reset";
    document.getElementById("options-resetall-button").style.setProperty("font-weight","bold","");
    
    setTimeout(function()
    {
        document.getElementById("options-resetall-button").innerText = "Reset All";
        document.getElementById("options-resetall-button").style.setProperty("font-weight","normal","");
    }
    ,1000);
}

/************************************************************************/

/* Clear All site levels */

function onClickClearAll(event)
{
    chrome.runtime.sendMessage({ type: "clearsitedata" });
    
    /* Display cleared status for short period */
    
    document.getElementById("options-clearall-button").innerText = "Cleared";
    document.getElementById("options-clearall-button").style.setProperty("font-weight","bold","");
    
    setTimeout(function()
    {
        document.getElementById("options-clearall-button").innerText = "Clear All Per-Site Data";
        document.getElementById("options-clearall-button").style.setProperty("font-weight","normal","");
    }
    ,1000);
}

/************************************************************************/
