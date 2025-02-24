
window.CommonJSFunctions = {
    GetIsNetworkAvailable: function () {
        return window.navigator.onLine;
    },
    back: function () {
        history.go(-1);
    },

    clearCache: function (isSetLocal = true) {
        var localkey = Object.keys(localStorage);
        var arrData = [];
        if (localkey && localkey.length > 0) {
            var comlocalkey = localkey.filter((x) => x.includes("_ComPrj"));
            comlocalkey.map((y) => {
                var localdata = localStorage.getItem(y);
                arrData.push(localdata);
            }
            );
        }

        $.ajax({
            url: "",
            context: document.body,
            success: function (s, x) {
                if ($('html[manifest=appsettings]')) {
                    $('html[manifest=appsettings]').attr('content', '');
                }
            }
        });

        /*unregister for the service worker  https://love2dev.com/blog/how-to-uninstall-a-service-worker/ */
        if ('serviceWorker' in navigator) {
            navigator.serviceWorker.ready.then(registration => {
                registration.update().then(() => {
                }
                );
            }
            );
            navigator.serviceWorker.getRegistrations().then(function (registrations) {
                for (let registration of registrations) {
                    registration.unregister()
                }
            }).catch(function (err) {
                console.log('Service Worker registration failed: ', err);
            });
        }

        // delete for cache
        caches.keys().then(keys => {
            keys.forEach(key => caches.delete(key))
        }
        );

        // delete  for index db
        if (indexedDB && indexedDB.databases) {
            indexedDB.databases().then(dbs => {
                dbs.forEach(db => {
                    if (db)
                        indexedDB.deleteDatabase(db.name)
                }
                )
            }
            );
        }

        // Delete for session
        sessionStorage.clear();

        // Delete for cookies
        var cookies = document.cookie.split(";");
        if (cookies) {
            for (var i = 0; i < cookies.length; i++) {
                var cookie = cookies[i];
                var eqPos = cookie.indexOf("=");
                var name = eqPos > -1 ? cookie.substr(0, eqPos) : cookie;
                document.cookie = name + "=;expires=Thu, 01 Jan 1970 00:00:00 GMT";
            }
        }
        localStorage.clear();
        window.location.assign("/");
    },

    GetIsNetworkAvailable: function () {
        return window.navigator.onLine;
    },

    getWindowScreen: function () {
        return {
            height: window.innerHeight,
            width: window.innerWidth
        };
    },

    getDevice: function () {
        const navigatorAgent = navigator.userAgent;
        if (navigatorAgent.match(/mobile/i)) {
            return 'mobile';
        } else if (navigatorAgent.match(/iPad|Android|Touch/i)) {
            return 'tablet';
        }
        return 'desktop';
    },

    focusIn: function (input, focusOut = false) {
        setTimeout(() => {
            var inputEle = document.getElementById(input);
            if (inputEle) {
                if (focusOut) {
                    inputEle.blur();
                } else {
                    inputEle.focus();
                }
            }
        }, 200);
    },

    CalHeight: function () {
        var mainbody = document.getElementById("main-body");
        var toolbar = document.getElementById("toolbar");
        var height = window.innerHeight;
        if (mainbody) {
            if (toolbar) {
                height = height - toolbar.clientHeight;
            }
            mainbody.style.height = height + "px";
        }
    },

    SetMainPageHeight: function () {
        var mainpage = document.getElementById("main-page");
        if (mainpage) {
            mainpage.style.height = window.innerHeight + "px";
        }
    },

    InitiateResize: function (dotNetHelper) {
        var resizeTimer;
        window.addEventListener("resize", () => {
            clearTimeout(resizeTimer);
            resizeTimer = setTimeout(function () {

                //set main page
                CommonJSFunctions.SetMainPageHeight();

                //invoke to C#
                if (dotNetHelper) {
                    dotNetHelper.invokeMethodAsync('GlobalResizeCaller', window.innerWidth, window.innerHeight);
                }

            }, 300);
        });
    },

    ToggleLoading: function (showloading) {
        var loading = document.getElementById("loading");
        if (loading) {
            if (showloading == true) {
                if (loading.classList.contains("loading-hide")) {
                    loading.classList.remove("loading-hide");
                }
            }
            else
            {
                if (!loading.classList.contains("loading-hide")) {
                    loading.classList.add("loading-hide");
                }
            }
           
        }
    },
    ShowErrorMessage: function (message) {
        var msgBox = document.getElementById("message");
        if (msgBox) {
            if (msgBox.classList.contains("message-hide")) {
                var messageBox = document.getElementById("msg-text");
                if (messageBox) {
                    messageBox.textContent = message;
                    msgBox.classList.remove("message-hide");
                }
            }
        }
    },
     CloseErrorMessage: function () {
        var msgBox = document.getElementById("message");
        if (msgBox) {
            if (!msgBox.classList.contains("message-hide")) {
                msgBox.classList.add("message-hide");
            }
        }
    },

    Focus: function (inputId) {
        var inputElement = document.getElementById(inputId);
        if (inputElement) {
            inputElement.focus();
        }
    },
    ScrollToElement: function (elementId) {
        var targetElement = document.getElementById(elementId);
        var mainbody = document.getElementById("main-body");
        if (targetElement && mainbody) {
            var targetPosition = targetElement.getBoundingClientRect().top + window.pageYOffset - 200;
            mainbody.scrollTo({
                top: targetPosition,
                behavior: 'smooth'
            });
        }
    }
}
