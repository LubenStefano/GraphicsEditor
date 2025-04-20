using System.Collections.Generic;
using GraphicsEditorShapes.ShapeClasses;

namespace GraphicsEditorShapes.ShapeCreation
{
    internal interface ICreateShape
    {
        Shape Create(Dictionary<string, string> data);
    }
}
