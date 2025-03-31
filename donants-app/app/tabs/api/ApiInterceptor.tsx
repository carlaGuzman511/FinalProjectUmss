// // import { useMsal } from '@azure/msal-react';
// import axios, { AxiosError, AxiosInstance, AxiosRequestConfig } from 'axios';
// import { useEffect, useState } from 'react';
// // import { B2C_CONSTANTS } from '../config/B2CConfig';
// // import { TokenHelper } from '../helpers/TokenHelper';
// // import { Props } from '../models/Props.types';

// const authApi: AxiosInstance = axios.create({
//     // withCredentials: true,
//     withCredentials: false,

//     headers: {
//         'Content-Type': 'application/json',
//     },
// });

// // export default function ApiInterceptor(props: Props) {
// //     const { children } = props;
// //     const { instance } = useMsal();
// //     const [isInitialized, setIsInitialized] = useState(false);

// //     useEffect(() => {
// //         const onRequest = async (config: AxiosRequestConfig) => {
// //             await instance.initialize();
// //             const account = instance.getAllAccounts()[0];

// //             if (account) {
// //                 await instance.acquireTokenSilent({
// //                     scopes: B2C_CONSTANTS.scopes,
// //                     account: account,
// //                     authority:
// //                         B2C_CONSTANTS.authorityPath +
// //                         '/' +
// //                         String(account?.tenantId),
// //                 });

// //                 const encodedTenant: string =
// //                     TokenHelper.getEncodedTenantInformation();
// //                 const accessToken: string = TokenHelper.getAccessToken();
// //                 config.headers!.Authorization = `Bearer ${accessToken}`;
// //                 config.headers!['encodedTenantInformation'] = encodedTenant
// //                     ? encodedTenant
// //                     : '';
// //             }

// //             return config;
// //         };

// //         const onRequestError = (error: AxiosError): Promise<AxiosError> => {
// //             return Promise.reject(error);
// //         };
// //         setIsInitialized(true);
// //         authApi.interceptors.request.use(onRequest, onRequestError);
// //     }, [instance]);
// //     return isInitialized ? <>{children}</> : <></>;
// // }

// export const api = {
//     get: function <T>(url: string, params?: object) {
//         return authApi.get<T>(url, {
//             ...params,
//         });
//     },
//     post: function <T>(url: string, data: any) {
//         return authApi.post<T>(url, data);
//     },
//     put: function <T>(url: string, data: any) {
//         return authApi.put<T>(url, data);
//     },
//     patch: function <T>(url: string, data: any) {
//         return authApi.patch<T>(url, data);
//     },
//     delete: function <T>(url: string, params?: object) {
//         return authApi.delete<T>(url, { params });
//     },
// };
