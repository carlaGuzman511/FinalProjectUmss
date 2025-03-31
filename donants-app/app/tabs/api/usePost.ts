// import { api } from './ApiInterceptor';
// import { Options, useGenericMutation } from './ReactQuery';

// export function usePost<T, TResponse = unknown>(
//     url: string,
//     options?: Options<T>
// ) {
//     return useGenericMutation<T, TResponse>(
//         (data) => api.post<TResponse>(url, data),
//         url,
//         {
//             ...options,
//             config: { retry: false },
//         }
//     );
// }
