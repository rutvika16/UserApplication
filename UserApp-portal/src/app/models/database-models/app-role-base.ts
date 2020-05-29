import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class AppRoleBase {

//#region roleId Prop
        @prop()
        roleId : number;
//#endregion roleId Prop


//#region roleName Prop
        @required()
        @maxLength({value:20})
        roleName : string;
//#endregion roleName Prop



}