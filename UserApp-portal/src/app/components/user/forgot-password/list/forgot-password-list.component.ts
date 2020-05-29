import { Component, OnInit, OnDestroy } from "@angular/core"
import { List } from "@rxweb/generics"
import { AbstractForgotPassword } from '../domain/abstract-forgot-password';
import { ForgotPassword } from "@app/models";
import { Subscription } from 'rxjs';

@Component({
    selector:"app-forgot-password-list",
    templateUrl:'./forgot-password-list.component.html'
})
export class ForgotPasswordListComponent extends AbstractForgotPassword implements OnInit, OnDestroy {
    forgotPassword: List<ForgotPassword>;
    subscription: Subscription;

    ngOnInit(): void {
        this.subscription = this.get().subscribe((t: List<ForgotPassword>) => {
            this.forgotPassword = t;
        })
    }


    ngOnDestroy(): void {
        if (this.subscription)
            this.subscription.unsubscribe();
    }

}
