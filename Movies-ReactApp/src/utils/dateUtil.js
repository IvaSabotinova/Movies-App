
export const formatDate = (isoDate) => {
    const options = { year: 'numeric', month: 'long', day: 'numeric' };
    const formattedDate = new Date(isoDate).toLocaleDateString('en-US', options);
    return formattedDate;
};
