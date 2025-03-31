// import { api } from './ApiInterceptor';
// import { Options, useGenericMutation } from './ReactQuery';

// export interface updateType<T> {
//     body: T;
//     id: number;
// }

// export function usePatch<T>(url: string, options?: Options<updateType<T>>) {
//     return useGenericMutation<updateType<T>>(
//         (data) => api.patch<updateType<T>>(`${url}/${data.id}`, data.body),
//         url,
//         {
//             ...options,
//             config: { retry: false },
//         }
//     );
// }
