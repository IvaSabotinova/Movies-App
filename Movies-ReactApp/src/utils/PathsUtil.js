
export const pathToUrl = (path, params) => {
    Object.keys(params).forEach((id) => {
        path = path.replace(`:${id}`, `${params[id]}`);
    });

    return path;
}

