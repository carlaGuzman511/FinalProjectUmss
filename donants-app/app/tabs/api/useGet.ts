// import { useQuery } from 'react-query';
// import { fetcher, Options, QueryKeyT } from './ReactQuery';
// import { AxiosError } from 'axios';
// // import { applicationInsights } from '../Insights';
// // import { TokenHelper } from '../helpers/TokenHelper';

// /**
//  * Function to automatically refetch the query.
//  */
// export function useGet<T>(
//     url: string | null,
//     enabled: boolean,
//     options?: Options<T>
// ) {
//     const context = useQuery<T, AxiosError, T, QueryKeyT>(
//         [url!, options?.params],
//         ({ queryKey }) => fetcher({ queryKey, meta: undefined }),
//         {
//             staleTime: options?.staleTime ?? Infinity,
//             refetchOnWindowFocus: false,
//             enabled: enabled,
//             retry: false,
//             onSuccess: (data) => {
//                 if (options?.onSuccess) {
//                     options?.onSuccess(data);
//                 }
//             },
//             onError: (error) => {
//                 // const initialData = TokenHelper.getInitialData();
                
//                 // applicationInsights.trackException(
//                 //     {
//                 //         error: {
//                 //             name: url!,
//                 //             message: JSON.stringify(
//                 //                 error,
//                 //                 Object.getOwnPropertyNames(error)
//                 //             ),
//                 //         },
//                 //     },
//                 //     initialData
//                 // );
//                 if (options?.onErrorCallback) {
//                     options?.onErrorCallback(error);
//                 }
//             },
//             ...options?.config,
//         }
//     );

//     return context;
// }
