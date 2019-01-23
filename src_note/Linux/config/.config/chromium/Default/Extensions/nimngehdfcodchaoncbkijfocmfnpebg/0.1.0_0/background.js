
var chronoid="mciiogijehkdemklbdcbfkefimifhecn";
chrome.browserAction.onClicked.addListener(function(){
    chrome.runtime.sendMessage(chronoid, { "cmd": "open_ui" });
});