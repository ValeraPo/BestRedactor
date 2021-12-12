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
                        main.PictureBox.Image = main.Picture.Bitmap;
                    main.tsBtnSelection.Checked = false;
                    break;

                //снятие выделенния с фигуры
                case >= Tools.Line:
                    main.tsSplitButtonShape.BackColor = SystemColors.Control;
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
                    main.tsBtnSelection.Checked = true;
                    break;
                
                //выделенная фигура
                case Tools.Line:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemLine.Image;
                    break;
                case Tools.DashLine:
                    main.tsSplitButtonShape.BackColor  = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemDashLine.Image;
                    break;
                case Tools.Ellipce:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemEllipce.Image;
                    break;
                case Tools.EllipceFill:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemEllipceFill.Image;
                    break;
                case Tools.Rectangle:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemRect.Image;
                    break;
                case Tools.RectangleFill:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemRectFill.Image;
                    break;
                case Tools.Circle:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemCircle.Image;
                    break;
                case Tools.CircleFill:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.tsBtnMenuItemCircleFill.Image;
                    break;
                case Tools.Square:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.toolStripMenuSquare.Image;
                    break;
                case Tools.SquareFill:
                    main.tsSplitButtonShape.BackColor = Color.FromArgb(125, SystemColors.GradientActiveCaption);
                    main.tsSplitButtonShape.BackgroundImage = main.toolStripMenuSquareFill.Image;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tools), tools, null);
            }
        }
    }
}