import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class TokenBase {

//#region tokenId Prop
        @prop()
        tokenId : number;
//#endregion tokenId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region createdDateTime Prop
        @required()
        createdDateTime : any;
//#endregion createdDateTime Prop


//#region expiryDateTime Prop
        @required()
        expiryDateTime : any;
//#endregion expiryDateTime Prop



}