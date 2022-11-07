# Getting Started

## Using UI

Open `shapes-ui` and run `npm i` and `npm run start`. This will launch a react app in <http://localhost:3000>

Open `Shapes` and run `Shapes.Api`, this will launch a web api in <https://localhost:7014>

Enter X, Y, EndPointX and EndPointY to draw the rectangles.

Click on Analyze to see the results

## Supported scenarios

X < EndPointX and Y < EndPointY

Adjacency types: Only Proper, Partial and None

Containment scenarios: Fully supported

Intersection scenarios: Not supported

## Running only WEB API

Open `Shapes` and run `Shapes.Api`, this will launch a web api in <https://localhost:7014> with swagger

Request should be:

{
    "rectangle1":{
        "startPointX":100,
        "startPointY":100,
        "endPointX":200,
        "endPointY":200
        },
    "rectangle2":{
        "startPointX":102,
        "startPointY":150,
        "endPointX":110,
        "endPointY":170
    }
}
