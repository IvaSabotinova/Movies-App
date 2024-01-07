
export const formatDetailsDate = (isoDate) => {
    const options = { year: 'numeric', month: 'long', day: 'numeric' };
    const formattedDate = new Date(isoDate).toLocaleDateString('en-US', options);
    return formattedDate;
};

export const formatInputDate = (date) =>{
    const formattedDate = new Date(date).toLocaleDateString('en-CA');    
    return formattedDate;
}
