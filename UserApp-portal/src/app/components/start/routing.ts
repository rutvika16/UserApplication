import { Routes, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { RouteProvider } from "@rxweb/angular-router"
import { Injectable } from '@angular/core';
var routings = [
    {
        path: '', redirectTo: 'login', pathMatch: 'full',
    },
    {
        path: "login",
        loadChildren: () => import("../login/login.module").then(m => m.LoginModule),
    },
]
        {
			path: "app-user",
			loadChildren: () => import("../user/app-user/app-user.module").then(m => m.AppUserModule)
		},
        {
			path: "forgot-password",
			loadChildren: () => import("../user/forgot-password/forgot-password.module").then(m => m.ForgotPasswordModule)
		},
        {
			path: "user-address",
			loadChildren: () => import("../user/user-address/user-address.module").then(m => m.UserAddressModule)
		},
//generated code
//])


export const ROUTES: Routes = routings;







console.log(ROUTES)

