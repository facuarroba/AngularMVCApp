﻿var AuthHttpResponseInterceptor = function ($q, $location, $injector) {
    return {
        response: function (response) {
            if (response.status === 401) {
                console.log("Response 401");
            }
            return response || $q.when(response);
        },
        responseError: function (rejection) {
            if (rejection.status === 401) {
                console.log("Response Error 401", rejection);
                $injector.get('$state').go('loginRegister', { returnUrl: $location.path() });
               // $location.path('/login').search('returnUrl', $location.path());
            }
            return $q.reject(rejection);
        }
    }
}

AuthHttpResponseInterceptor.$inject = ['$q', '$location','$injector'];