import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vViewUserBase {

//#region userName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'userName', keyColumn: false})
        userName : string;
//#endregion userName Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region lastName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'lastName', keyColumn: false})
        lastName : string;
//#endregion lastName Prop


//#region mobileNumber Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'mobileNumber', keyColumn: false})
        mobileNumber : string;
//#endregion mobileNumber Prop


//#region emailId Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'emailId', keyColumn: false})
        emailId : string;
//#endregion emailId Prop


//#region addressType Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'addressType', keyColumn: false})
        addressType : string;
//#endregion addressType Prop


//#region houseNumber Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'houseNumber', keyColumn: false})
        houseNumber : string;
//#endregion houseNumber Prop


//#region area Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'area', keyColumn: false})
        area : string;
//#endregion area Prop


//#region landmark Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'landmark', keyColumn: false})
        landmark : string;
//#endregion landmark Prop


//#region city Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'city', keyColumn: false})
        city : string;
//#endregion city Prop


//#region state Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'state', keyColumn: false})
        state : string;
//#endregion state Prop


//#region userId Prop
        @gridColumn({visible: true, columnIndex:11, allowSorting: true, headerKey: 'userId', keyColumn: true})
        userId : number;
//#endregion userId Prop

}