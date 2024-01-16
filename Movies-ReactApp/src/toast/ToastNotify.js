import { toast } from 'react-toastify';


const ToastNotify = (message, type = 'success') => {
 const toastConfig = (message, {
        position: "top-right",
        autoClose: 3000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: undefined,
        theme: "dark",
    });

    switch (type) {
        case 'success': toast.success(message, toastConfig); break;
        case 'info': toast.info(message, toastConfig); break;
        case 'warning': toast.warning(message, toastConfig); break;
        case 'error': toast.error(message, toastConfig); break;
        default: toast(message, toastConfig); break;
    }
}


export default ToastNotify;

