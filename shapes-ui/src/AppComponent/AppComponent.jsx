import React, { useState } from "react";
import { Stage, Layer, Rect } from "react-konva";
import InputValues from "./InputValues";
import "./AppComponent.css";
import axios from "axios";

const AppComponent = () => {
  const [rectangle1, setRectangle1] = useState({});
  const [rectangle2, setRectangle2] = useState({});
  const [response, setResponse] = useState(null);

  const onClickAnalyze = () => {
    if (!(rectangle1.startPointX && rectangle1.startPointY && rectangle1.endPointX && rectangle1.endPointY)) {
      return;
    }

    if (!(rectangle2.startPointX && rectangle2.startPointY && rectangle2.endPointX && rectangle2.endPointY)) {
      return;
    }

    const request = {
      rectangle1: rectangle1,
      rectangle2: rectangle2,
    };
    axios.defaults.headers.post["Content-Type"] = `application/json`;
    axios.post("https://localhost:7014/RectangleAnalizer", JSON.stringify(request)).then((responseValue) => {
      setResponse(responseValue.data);
    });
  };

  return (
    <>
      <div className="container">
        <h1>Rectangle Analizer</h1>
        <InputValues
          onChangeX={(value) => {
            const rectangle = { ...rectangle1 };
            rectangle.startPointX = value;
            setRectangle1(rectangle);
          }}
          onChangeY={(value) => {
            const rectangle = { ...rectangle1 };
            rectangle.startPointY = value;
            setRectangle1(rectangle);
          }}
          onChangeWidth={(value) => {
            const rectangle = { ...rectangle1 };
            rectangle.endPointX = value;
            setRectangle1(rectangle);
          }}
          onChangeHeight={(value) => {
            const rectangle = { ...rectangle1 };
            rectangle.endPointY = value;
            setRectangle1(rectangle);
          }}
        />
        <InputValues
          onChangeX={(value) => {
            const rectangle = { ...rectangle2 };
            rectangle.startPointX = value;
            setRectangle2(rectangle);
          }}
          onChangeY={(value) => {
            const rectangle = { ...rectangle2 };
            rectangle.startPointY = value;
            setRectangle2(rectangle);
          }}
          onChangeWidth={(value) => {
            const rectangle = { ...rectangle2 };
            rectangle.endPointX = value;
            setRectangle2(rectangle);
          }}
          onChangeHeight={(value) => {
            const rectangle = { ...rectangle2 };
            rectangle.endPointY = value;
            setRectangle2(rectangle);
          }}
        />
        <button onClick={() => onClickAnalyze()}>Analyze</button>
        <h2 className="iscontained">
          Is contained?: <span>{(response && response.isContained && "True") || "False"}</span>
        </h2>
        <h2 className="adjacent">
          Adjacency type: <span>{response && response.adjacencyType}</span>
        </h2>
      </div>
      <Stage width={window.innerWidth} height={window.innerHeight}>
        <Layer>
          <Rect
            x={rectangle1.startPointX}
            y={rectangle1.startPointY}
            width={rectangle1.endPointX - rectangle1.startPointX}
            height={rectangle1.endPointY - rectangle1.startPointY}
            strokeWidth={1}
            stroke="blue"
          />
          <Rect
            x={rectangle2.startPointX}
            y={rectangle2.startPointY}
            width={rectangle2.endPointX - rectangle2.startPointX}
            height={rectangle2.endPointY - rectangle2.startPointY}
            strokeWidth={1}
            stroke="red"
          />
        </Layer>
      </Stage>
    </>
  );
};

export default AppComponent;
