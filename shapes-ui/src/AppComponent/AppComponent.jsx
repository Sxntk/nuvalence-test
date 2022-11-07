import React, { useState } from "react";
import { Stage, Layer, Rect } from "react-konva";
import InputValues from "./InputValues";

const AppComponent = () => {
  const [rectangle1, setRectangle1] = useState({});
  const [rectangle2, setRectangle2] = useState({});

  return (
    <>
      <InputValues
        onChangeX={(value) => {
          const rectangle = { ...rectangle1 };
          rectangle.x = value;
          setRectangle1(rectangle);
        }}
        onChangeY={(value) => {
          const rectangle = { ...rectangle1 };
          rectangle.y = value;
          setRectangle1(rectangle);
        }}
        onChangeWidth={(value) => {
          const rectangle = { ...rectangle1 };
          rectangle.width = value;
          setRectangle1(rectangle);
        }}
        onChangeHeight={(value) => {
          const rectangle = { ...rectangle1 };
          rectangle.height = value;
          setRectangle1(rectangle);
        }}
      />
      <InputValues
        onChangeX={(value) => {
          const rectangle = { ...rectangle2 };
          rectangle.x = value;
          setRectangle2(rectangle);
        }}
        onChangeY={(value) => {
          const rectangle = { ...rectangle2 };
          rectangle.y = value;
          setRectangle2(rectangle);
        }}
        onChangeWidth={(value) => {
          const rectangle = { ...rectangle2 };
          rectangle.width = value;
          setRectangle2(rectangle);
        }}
        onChangeHeight={(value) => {
          const rectangle = { ...rectangle2 };
          rectangle.height = value;
          setRectangle2(rectangle);
        }}
      />
      <Stage width={window.innerWidth} height={window.innerHeight}>
        <Layer>
          <Rect x={rectangle1.x} y={rectangle1.y} width={rectangle1.width} height={rectangle1.height} strokeWidth={1} stroke="blue" />
          <Rect x={rectangle2.x} y={rectangle2.y} width={rectangle2.width} height={rectangle2.height} strokeWidth={1} stroke="red" />
        </Layer>
      </Stage>
    </>
  );
};

export default AppComponent;
