var AngularMVCApp = angular.module('AngularMVCApp', ['ui.router', 'ui.bootstrap']);

AngularMVCApp.controller('LandingPageController', LandingPageController);
AngularMVCApp.controller('LoginController', LoginController);
AngularMVCApp.controller('RegisterController', RegisterController);

AngularMVCApp.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
AngularMVCApp.factory('LoginFactory', LoginFactory);
AngularMVCApp.factory('RegistrationFactory', RegistrationFactory);

var configFunction = function ($stateProvider, $httpProvider, $locationProvider) {
    $locationProvider.hashPrefix('!').html5Mode(true);

    $stateProvider
        .state('stateOne', {
            url: '/stateOne?donuts',
            views: {
                "containerOne": {
                    templateUrl: '/routesDemo/one'
                },
                "containerTwo": {
                    templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
                },
                "nestedView@stateOne": {
                    templateUrl: '/routesDemo/four'
                }
            }

        })
        .state('stateTwo', {
            url: '/stateTwo',
            views: {
                "containerOne": {
                    templateUrl: '/routesDemo/one'
                },
                "containerTwo": {
                    templateUrl: '/routesDemo/three'
                }
            }
        })
        .state('stateThree', {
            url: '/stateThree?donuts',
            views: {
                "containerOne": {
                    templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
                },
                "containerTwo": {
                    templateUrl: '/routesDemo/three'
                }
            }
        })
        .state('loginRegister', {
            url: '/loginRegister?returnUrl',
            views: {
                "containerOne": {
                    templateUrl: '/Account/Login',
                    controller: LoginController
                },
                "containerTwo": {
                    templateUrl: '/Account/Register',
                    controller: RegisterController
                }
            }
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');
}
configFunction.$inject = ['$stateProvider', '$httpProvider','$locationProvider'];

AngularMVCApp.config(configFunction);