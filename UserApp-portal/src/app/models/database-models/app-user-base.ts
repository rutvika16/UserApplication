import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class AppUserBase {

//#region appUserId Prop
        @prop()
        appUserId : number;
//#endregion appUserId Prop


//#region firstName Prop
        @required()
        @maxLength({value:20})
        firstName : string;
//#endregion firstName Prop


//#region lastName Prop
        @required()
        @maxLength({value:20})
        lastName : string;
//#endregion lastName Prop


//#region mobileNumber Prop
        @required()
        @maxLength({value:15})
        mobileNumber : string;
//#endregion mobileNumber Prop


//#region emailId Prop
        @required()
        @maxLength({value:50})
        emailId : string;
//#endregion emailId Prop


//#region birthDate Prop
        @required()
        birthDate : Date;
//#endregion birthDate Prop


//#region gender Prop
        @maxLength({value:6})
        gender : string;
//#endregion gender Prop


//#region password Prop
        @required()
        @maxLength({value:132})
        password : any;
//#endregion password Prop


//#region salt Prop
        @maxLength({value:140})
        salt : any;
//#endregion salt Prop


//#region createdDateTime Prop
        @required()
        createdDateTime : any;
//#endregion createdDateTime Prop


//#region updatedDateTime Prop
        @required()
        updatedDateTime : any;
//#endregion updatedDateTime Prop


//#region roleId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        roleId : number;
//#endregion roleId Prop


//#region status Prop
        @required()
        status : boolean;
//#endregion status Prop


//#region userName Prop
        @required()
        @maxLength({value:20})
        userName : string;
//#endregion userName Prop







}