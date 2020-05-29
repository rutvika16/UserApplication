import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ForgotPasswordListComponent } from './list/forgot-password-list.component';
import { ForgotPasswordAddComponent } from './add/forgot-password-add.component';
import { ForgotPasswordEditComponent } from './edit/forgot-password-edit.component';

const ROUTES: Routes = [
    {
        path: '',
        component: ForgotPasswordListComponent
    },
    {
        path: 'add',
        component: ForgotPasswordAddComponent
    },
    {
        path: ':id',
        component:  ForgotPasswordEditComponent
    },
];

export const ROUTING: ModuleWithProviders = RouterModule.forChild(ROUTES);
