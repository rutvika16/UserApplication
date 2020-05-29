import {AppUserBase} from '../database-models/app-user-base';
import {AppRoleBase} from '../database-models/app-role-base';
import {UserAddressBase} from '../database-models/user-address-base';
import {TokenBase} from '../database-models/token-base';
//Generated Imports
export class AppUser extends AppUserBase 
{




//#region Generated Reference Properties
//#region appRole Prop
        appRole : AppRoleBase;
//#endregion appRole Prop

//#region userAddresses Prop
        userAddresses : UserAddressBase[];
//#endregion userAddresses Prop

//#region tokens Prop
        tokens : TokenBase[];
//#endregion tokens Prop

//#endregion Generated Reference Properties
}