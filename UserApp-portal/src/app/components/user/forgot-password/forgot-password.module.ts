import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { RxReactiveFormsModule } from "@rxweb/reactive-form-validators";

import { ROUTING } from './forgot-password.routing'

import { ForgotPasswordListComponent } from './list/forgot-password-list.component'
import { ForgotPasswordEditComponent } from './edit/forgot-password-edit.component';
import { ForgotPasswordAddComponent } from './add/forgot-password-add.component';
import { ForgotPasswordSharedModule } from './forgot-password-shared.module';

@NgModule({
    imports: [
        CommonModule, FormsModule, ReactiveFormsModule, RxReactiveFormsModule,ForgotPasswordSharedModule,
        ROUTING
    ],
    declarations: [ForgotPasswordListComponent,ForgotPasswordEditComponent,ForgotPasswordAddComponent],
    exports: [RouterModule],
    providers: []
})
export class ForgotPasswordModule { }


