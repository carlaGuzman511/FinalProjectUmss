// import { api } from './ApiInterceptor';
// import { Options, useGenericMutation } from './ReactQuery';

// export interface updateType<T> {
//     body: T;
//     id: string;
// }

// export function usePut<T, TResponse = unknown>(
//     url: string,
//     options?: Options<updateType<T>>
// ) {
//     return useGenericMutation<updateType<T>, TResponse>(
//         (data) => api.put<TResponse>(`${url}/${data.id}`, data.body),
//         url,
//         {
//             ...options,
//             config: { retry: false },
//         }
//     );
// }
