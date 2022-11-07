import React from "react";
import "./InputValues.css";

const InputValues = ({ onChangeX, onChangeY, onChangeWidth, onChangeHeight }) => {
  return (
    <div className="input-values-root">
      <input placeholder="X" onChange={(event) => onChangeX(+event.target.value)}></input>
      <input placeholder="Y" onChange={(event) => onChangeY(+event.target.value)}></input>
      <input placeholder="Width" onChange={(event) => onChangeWidth(+event.target.value)}></input>
      <input placeholder="Height" onChange={(event) => onChangeHeight(+event.target.value)}></input>
    </div>
  );
};

export default InputValues;
