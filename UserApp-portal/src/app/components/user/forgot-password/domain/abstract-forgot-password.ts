import { RxHttp } from "@rxweb/http";
import { IFormGroup } from '@rxweb/reactive-form-validators';
import { ForgotPassword } from '@app/models';

export class AbstractForgotPassword extends RxHttp {
    forgotPasswordFormGroup: IFormGroup<ForgotPassword>
}
