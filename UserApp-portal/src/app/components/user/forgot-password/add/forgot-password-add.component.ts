import { Component, OnInit, OnDestroy } from "@angular/core"
import { Subscription } from 'rxjs';

import { RxFormBuilder, IFormGroup } from '@rxweb/reactive-form-validators';

import { ForgotPassword } from '@app/models';
import { AbstractForgotPassword } from '../domain/abstract-forgot-password';

@Component({
    selector: "app-forgot-password-add",
    templateUrl: './forgot-password-add.component.html'
})
export class ForgotPasswordAddComponent extends AbstractForgotPassword implements OnInit, OnDestroy {
    forgotPassword: ForgotPassword;
    subscription: Subscription;

    constructor(private formBuilder: RxFormBuilder) {
        super();
    }

    ngOnInit(): void {
        this.forgotPassword = new ForgotPassword();
        this.forgotPasswordFormGroup = this.formBuilder.formGroup(this.forgotPassword) as IFormGroup<ForgotPassword>;
    }

    ngOnDestroy(): void {
        if (this.subscription)
            this.subscription.unsubscribe();
    }

}
