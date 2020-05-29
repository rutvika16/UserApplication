import { Component, OnInit, OnDestroy } from "@angular/core"
import { AbstractForgotPassword } from '../domain/abstract-forgot-password';

import { Subscription } from 'rxjs';
import { RxFormBuilder, IFormGroup } from '@rxweb/reactive-form-validators';
import { ActivatedRoute } from '@angular/router';

import { ForgotPassword } from '@app/models';

@Component({
    selector: "app-forgot-password-edit",
    templateUrl: './forgot-password-edit.component.html'
})
export class ForgotPasswordEditComponent extends AbstractForgotPassword implements OnInit, OnDestroy {
    forgotPassword: ForgotPassword;
    subscription: Subscription;
    id: number;

    constructor(private formBuilder: RxFormBuilder, private activatedRoute: ActivatedRoute) {
        super();
        this.activatedRoute.queryParams.subscribe(t => {
            this.id = t['id'];
        })
    }

    ngOnInit(): void {
        this.get({ params: [this.id] }).subscribe(t => {
            this.forgotPasswordFormGroup = this.formBuilder.formGroup(ForgotPassword,t) as IFormGroup<ForgotPassword>;
        })
    }

    ngOnDestroy(): void {
        if (this.subscription)
            this.subscription.unsubscribe();
    }

}
