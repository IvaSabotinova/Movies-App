
function Loader() {
  return (
    <div
      style={{
        position: "fixed",
        top: "0",
        left: "0",
        width: "100vw",
        height: "100vh",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        backgroundColor: "#e2f6fb"
      }}
    >
      <div
        className="spinner-border text-info"
        style={{
          width: "4rem",
          height: "4rem",
        }}
      ></div>
    </div>
  );
}

export default Loader;