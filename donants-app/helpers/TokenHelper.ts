// import { IPublicClientApplication, AccountInfo } from '@azure/msal-browser';
// import { NavigateFunction } from 'react-router-dom';
// import jwt_decode from 'jwt-decode';
// import { B2C_CONSTANTS } from '../config/B2CConfig';
// import {
//     EmailHashResponse,
//     EmailSignupResponse,
//     TokenData,
//     UserInformation,
// } from '../models/App.interfaces';
// import {
//     COMPANY_NAME_KEY,
//     CONTACT_INFORMATION_KEY,
//     ENCODED_TENANT_KEY,
//     LOGO_KEY,
//     NAME_KEY,
//     SESSION_DATA_KEY,
//     USER_INFO_KEY,
// } from './Constants';

// export abstract class TokenHelper {
//     static saveInitialData(data: TokenData) {
//         sessionStorage.setItem(SESSION_DATA_KEY, JSON.stringify(data));
//     }

//     static saveInitialDataFromTenant(encodedTenant: string) {
//         const decodedToken: {
//             tenantId: string;
//             publicKey: string;
//         } = jwt_decode(encodedTenant);

//         const tokenData: TokenData = {
//             tenantId: decodedToken.tenantId,
//             publicKey: decodedToken.publicKey,
//             customerName: '',
//             customerNumber: '',
//             allowCreditCard: false,
//             allowACH: false,
//             encodedTenantInformation: '',
//         };

//         TokenHelper.saveInitialData(tokenData);
//     }

//     static getInitialData(): TokenData {
//         return JSON.parse(sessionStorage.getItem(SESSION_DATA_KEY) || '{}');
//     }

//     static saveSessionStorage(
//         logo: string,
//         contactInformation: string,
//         name: string
//     ) {
//         sessionStorage.setItem(LOGO_KEY, logo);
//         sessionStorage.setItem(CONTACT_INFORMATION_KEY, contactInformation);
//         sessionStorage.setItem(NAME_KEY, name);
//     }

//     static deleteSession() {
//         sessionStorage.removeItem(SESSION_DATA_KEY);
//         sessionStorage.removeItem(ENCODED_TENANT_KEY);
//         sessionStorage.removeItem(USER_INFO_KEY);
//     }

//     static getCompanyName() {
//         const formattedUrl = window.location.pathname.replace(/%0d%0a/g, ' ');
//         const companyName: string = formattedUrl.split('/')[1].toLowerCase();

//         const lastCompanyName = sessionStorage.getItem(COMPANY_NAME_KEY) || '';
//         if (lastCompanyName !== companyName) {
//             TokenHelper.deleteSession();
//         }

//         sessionStorage.setItem(COMPANY_NAME_KEY, companyName);
//         return companyName;
//     }

//     static getHashValues(): EmailSignupResponse {
//         const hashValues: string = window.location.hash.replace('#', '');
//         if (hashValues === '') {
//             return {
//                 companyName: '',
//                 idToken: '',
//                 error: '',
//                 errorDescription: '',
//             };
//         }

//         const params = new URLSearchParams(hashValues);
//         const result: EmailHashResponse = Object.fromEntries(params);

//         return {
//             companyName: result.state || '',
//             idToken: result.id_token || '',
//             error: result.error || '',
//             errorDescription: result.error_description || '',
//         };
//     }

//     static getAccessToken(): string {
//         const tokenData = JSON.parse(
//             sessionStorage.getItem(B2C_CONSTANTS.keyToken) || '{}'
//         );
//         const accessTokenKey = tokenData.accessToken
//             ? tokenData.accessToken[0]
//             : '';
//         let accessToken = '';
//         if (accessTokenKey !== '') {
//             const accessTokenData = JSON.parse(
//                 sessionStorage.getItem(accessTokenKey) || '{}'
//             );
//             accessToken = accessTokenData.secret || '';
//         }
//         return accessToken;
//     }

//     static saveAuthData(data: UserInformation) {
//         // Saving Encoded tenant in a different key because we retrieve it from other models too
//         if (data.encodedTenantInformation !== undefined) {
//             TokenHelper.saveEncodedTenantInformation(
//                 data.encodedTenantInformation
//             );
//         }
//         TokenHelper.saveUserInformation(data);
//     }

//     static saveEncodedTenantInformation(value: string) {
//         sessionStorage.setItem(ENCODED_TENANT_KEY, value);
//     }
//     static saveUserInformation(data: UserInformation) {
//         sessionStorage.setItem(USER_INFO_KEY, JSON.stringify(data));
//     }

//     static getEncodedTenantInformation(): string {
//         return sessionStorage.getItem(ENCODED_TENANT_KEY) || '';
//     }

//     static getUserInformation(): UserInformation {
//         return JSON.parse(sessionStorage.getItem(USER_INFO_KEY) || '{}');
//     }

//     static logout(
//         instance: IPublicClientApplication,
//         navigate: NavigateFunction,
//         onSignIn?: boolean
//     ) {
//         if (!onSignIn || onSignIn === undefined) {
//             TokenHelper.deleteSession();
//         }
//         const accounts: AccountInfo[] = instance.getAllAccounts();
//         if (accounts.length > 0) {
//             const currentAccount = accounts[0];
//             instance.logoutPopup({
//                 authority:
//                     B2C_CONSTANTS.authorityPath +
//                     '/' +
//                     String(currentAccount?.tenantId),
//                 account: currentAccount,
//                 idTokenHint: currentAccount?.idToken,
//             });
//         } else {
//             navigate('/');
//         }
//     }

//     static logoutOnChangePassword(
//         instance: IPublicClientApplication,
//         account: AccountInfo
//     ) {
//         instance.logoutPopup({
//             authority: B2C_CONSTANTS.authorityChangePassword,
//             account: account,
//             idTokenHint: account?.idToken,
//         });
//     }
// }
