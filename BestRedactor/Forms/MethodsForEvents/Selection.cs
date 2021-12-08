using System;
using BestRedactor.Enums;
using BestRedactor.Logics;

namespace BestRedactor.Forms.MethodsForEvents
{
    public static class Selection
    {
        internal static void DisableSelect(Tools tools, ref Tools currentTool, MainForm main)
        {
            switch (currentTool) //Снятие выделения
            {
                //снятие выделения
                case Tools.Brush:
                    main.tsBtnBrush.Size = main._notSelectSizeTools;
                    break;
                case Tools.Pencil:
                    main.tsBtnPen.Size = main._notSelectSizeTools;
                    break;
                case Tools.Cursor:
                    main.tsButtonCursor.Size = main._notSelectSizeTools;
                    break;
                case Tools.Erase:
                    main.tsBtnEraser.Size = main._notSelectSizeTools;
                    break;
                case Tools.Pipette:
                    main.tsBtnPipette.Size = main._notSelectSizeTools;
                    break;
                case Tools.Fill:
                    main.tsBtnFill.Size = main._notSelectSizeTools;
                    break;
                case Tools.Text:
                    main.tsText.Size = main._notSelectSizeTools;
                    break;
                case Tools.Cropping:
                    if (Settings.OpenedTabs != 0)
                        main._pictureBox.Image = main._picture.Bitmap;
                    main.tsButtonFraming.Size = main._notSelectSizeTools;
                    break;
                
                
                case Tools.Line:
                case Tools.DashLine:
                case Tools.Ellipce:
                case Tools.EllipceFill:
                case Tools.Rectangle:
                case Tools.RectangleFill:
                case Tools.Circle:
                case Tools.CircleFill:
                case Tools.Square:
                case Tools.SquareFill:
                    main.tsSplitButtonShape.Size = main._notSelectSizeFigure;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tools), tools, null);
            }

            currentTool = tools;
            switch (tools) //Установка выделения
            {
                case Tools.Brush:
                    main.tsBtnBrush.Size = main._selectSizeTools;
                    break;
                case Tools.Pencil:
                    main.tsBtnPen.Size = main._selectSizeTools;
                    break;
                case Tools.Cursor:
                    main.tsButtonCursor.Size = main._selectSizeTools;
                    break;
                case Tools.Erase:
                    main.tsBtnEraser.Size = main._selectSizeTools;
                    break;
                case Tools.Pipette:
                    main.tsBtnPipette.Size = main._selectSizeTools;
                    break;
                case Tools.Fill:
                    main.tsBtnFill.Size = main._selectSizeTools;
                    break;
                case Tools.Text:
                    main.tsText.Size = main._selectSizeTools;
                    break;
                case Tools.Cropping:
                    main.tsButtonFraming.Size = main._selectSizeTools;
                    break;
                
                
                case Tools.Line:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemLine.Image;
                    break;
                case Tools.DashLine:
                    main.tsSplitButtonShape.Size  = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemDashLine.Image;
                    break;
                case Tools.Ellipce:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemEllipce.Image;
                    break;
                case Tools.EllipceFill:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemEllipceFill.Image;
                    break;
                case Tools.Rectangle:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemRect.Image;
                    break;
                case Tools.RectangleFill:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemRectFill.Image;
                    break;
                case Tools.Circle:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemCircle.Image;
                    break;
                case Tools.CircleFill:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemCircleFill.Image;
                    break;
                case Tools.Square:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.toolStripMenuSquare.Image;
                    break;
                case Tools.SquareFill:
                    main.tsSplitButtonShape.Size = main._selectSizeFigure;
                    main.tsSplitButtonShape.Image = main.toolStripMenuSquareFill.Image;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tools), tools, null);
            }
        }
    }
}