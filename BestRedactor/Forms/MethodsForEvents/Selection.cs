using System;
using System.Drawing;
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
                    main.tsBtnBrush.Checked = false;
                    break;
                case Tools.Pencil:
                    main.tsBtnPen.Checked = false;
                    break;
                case Tools.Cursor:
                    main.tsButtonCursor.Checked = false;
                    break;
                case Tools.Erase:
                    main.tsBtnEraser.Checked = false;
                    break;
                case Tools.Pipette:
                    main.tsBtnPipette.Checked = false;
                    break;
                case Tools.Fill:
                    main.tsBtnFill.Checked = false;
                    break;
                case Tools.Text:
                    main.tsText.Checked = false;
                    break;
                case Tools.Selection:
                    if (Settings.OpenedTabs != 0)
                        main._pictureBox.Image = main._picture.Bitmap;
                    main.tsButtonFraming.Checked = false;
                    break;

                //снятие выделенния с фигуры
                case Tools.Line:
                    main.tsSplitButtonShape.BackColor = SystemColors.Control;
                    break;
                case Tools.DashLine:
                    break;
                case Tools.Circle:
                    break;
                case Tools.Ellipce:
                    break;
                case Tools.Rectangle:
                    break;
                case Tools.Square:
                    break;
                case Tools.CircleFill:
                    break;
                case Tools.EllipceFill:
                    break;
                case Tools.RectangleFill:
                    break;
                case Tools.SquareFill:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(currentTool), currentTool, null);
            }

            currentTool = tools;
            switch (tools) //Установка выделения
            {
                case Tools.Brush:
                    main.tsBtnBrush.Checked = true;
                    break;
                case Tools.Pencil:
                    main.tsBtnPen.Checked = true;
                    break;
                case Tools.Cursor:
                    main.tsButtonCursor.Checked = true;
                    break;
                case Tools.Erase:
                    main.tsBtnEraser.Checked = true;
                    break;
                case Tools.Pipette:
                    main.tsBtnPipette.Checked = true;
                    break;
                case Tools.Fill:
                    main.tsBtnFill.Checked = true;
                    break;
                case Tools.Text:
                    main.tsText.Checked = true;
                    break;
                case Tools.Selection:
                    main.tsButtonFraming.Checked = true;
                    break;
                
                //выделенная фигура
                case Tools.Line:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemLine.Image;
                    break;
                case Tools.DashLine:
                    main.tsSplitButtonShape.BackColor  = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemDashLine.Image;
                    break;
                case Tools.Ellipce:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemEllipce.Image;
                    break;
                case Tools.EllipceFill:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemEllipceFill.Image;
                    break;
                case Tools.Rectangle:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemRect.Image;
                    break;
                case Tools.RectangleFill:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemRectFill.Image;
                    break;
                case Tools.Circle:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemCircle.Image;
                    break;
                case Tools.CircleFill:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.tsBtnMenuItemCircleFill.Image;
                    break;
                case Tools.Square:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.toolStripMenuSquare.Image;
                    break;
                case Tools.SquareFill:
                    main.tsSplitButtonShape.BackColor = Color.Turquoise;
                    main.tsSplitButtonShape.Image = main.toolStripMenuSquareFill.Image;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tools), tools, null);
            }
        }
    }
}