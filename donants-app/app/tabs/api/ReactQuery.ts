// import { api } from './ApiInterceptor';
// import { useMutation, useQueryClient, UseQueryOptions } from 'react-query';
// import { QueryFunctionContext } from 'react-query/types/core/types';
// import { AxiosError, AxiosResponse } from 'axios';
// // import { applicationInsights } from '../Insights';
// // import { TokenHelper } from '../helpers/TokenHelper';

// export type QueryKeyT = [string, object | undefined];

// export interface Options<T> {
//     params?: object;
//     config?: UseQueryOptions<T, AxiosError, T, QueryKeyT>;
//     staleTime?: number;
//     onErrorCallback?: (error: AxiosError, data?: T) => Promise<void> | void;
//     onSuccess?: (data: T) => Promise<void> | void;
// }

// export function fetcher<T>({
//     queryKey,
//     pageParam,
//     meta,
// }: QueryFunctionContext<QueryKeyT>): Promise<T> {
//     const [url, params] = queryKey;
//     return api
//         .get<T>(url, { params: { ...params, pageParam } })
//         .then((res) => res.data);
// }

// export const useGenericMutation = <T, TResponse = unknown>(
//     apiFunction: (data: T, id?: string) => Promise<AxiosResponse<TResponse>>,
//     url: string,
//     options?: Options<T>
// ) => {
//     const queryClient = useQueryClient();

//     return useMutation<AxiosResponse<TResponse>, AxiosError, T>(apiFunction, {
//         onSuccess: (response, data) => {
//             if (options?.onSuccess) {
//                 options?.onSuccess(data);
//             }
//         },
//         onError: (error, data, context) => {
//             // const initialData = TokenHelper.getInitialData();

//             // applicationInsights.trackException(
//             //     {
//             //         error: {
//             //             name: url,
//             //             message:
//             //                 error.response?.data ||
//             //                 JSON.stringify(
//             //                     error,
//             //                     Object.getOwnPropertyNames(error)
//             //                 ),
//             //         },
//             //     },
//             //     initialData
//             // );

//             queryClient.setQueryData([url!, options?.params], context);
//             if (options?.onErrorCallback) {
//                 options?.onErrorCallback(error, data);
//             }
//         },
//     });
// };
