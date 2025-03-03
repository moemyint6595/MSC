var ResizeHelper;
var resizeTimer;
function InitDotNetHelper(dotNetHelper) {
    this.ResizeHelper = dotNetHelper;
}

function DisposeResizeHelper() {
    this.ResizeHelper = undefined;
}

function SetMainPageHeight () {
    var mainpage = document.getElementById("page");
    console.log("mainpage =>", mainpage);
    if (mainpage) {
        mainpage.style.height = window.innerHeight + "px";
    }
}

function ResizeHandler() {
    SetMainPageHeight();
    if (this.ResizeHelper) {
        this.ResizeHelper.invokeMethodAsync('ResizeCaller', window.innerWidth, window.innerHeight);
    }
}

window.addEventListener("resize", () => {
    clearTimeout(resizeTimer);
    resizeTimer = setTimeout(ResizeHandler, 300);
});