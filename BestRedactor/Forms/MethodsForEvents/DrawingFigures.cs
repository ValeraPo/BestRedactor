using BestRedactor.Enums;
using BestRedactor.Logics;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BestRedactor.Forms.MethodsForEvents
{
    internal class DrawingFigures
    {
        internal static Rectangle DrawAFigure(Graphics g, Tools currentTool, Pen pen, int cX, int cY, int sX, int sY, int x, int y)
        {
            var tmp = new Rectangle();
            var penTmp = new Pen(Color.Blue, 0.8f);
            penTmp.DashStyle = DashStyle.Dash;
            penTmp.DashPattern = new[] { 20f, 10 };
            switch (currentTool)
            {
                case Tools.Line:
                    g.DrawLine(pen, cX, cY, x, y);
                    break;
                case Tools.DashLine:
                    pen.DashStyle = DashStyle.Dash;
                    g.DrawLine(pen, cX, cY, x, y);
                    pen.DashStyle = DashStyle.Solid;
                    break;


                case Tools.Ellipce:
                    g.DrawEllipse(pen, cX, cY, sX, sY);
                    break;
                case Tools.EllipceFill:
                    g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, sX, sY);
                    break;


                case Tools.Rectangle when sX > 0 && sY > 0:
                    g.DrawRectangle(pen, cX, cY, sX, sY);
                    break;
                case Tools.Rectangle when sX < 0 && sY > 0:
                    g.DrawRectangle(pen, cX + sX, cY, Math.Abs(sX), sY);
                    break;
                case Tools.Rectangle when sX > 0 && sY < 0:
                    g.DrawRectangle(pen, cX, cY + sY, sX, Math.Abs(sY));
                    break;
                case Tools.Rectangle when sX < 0 && sY < 0:
                    g.DrawRectangle(pen, cX + sX, cY + sY, Math.Abs(sX), Math.Abs(sY));
                    break;
                case Tools.RectangleFill when sX > 0 && sY > 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX, cY, sX, sY);
                    break;
                case Tools.RectangleFill when sX < 0 && sY > 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX + sX, cY, Math.Abs(sX), sY);
                    break;
                case Tools.RectangleFill when sX > 0 && sY < 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX, cY + sY, sX, Math.Abs(sY));
                    break;
                case Tools.RectangleFill when sX < 0 && sY < 0:
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX + sX, cY + sY, Math.Abs(sX), Math.Abs(sY));
                    break;


                case Tools.Circle:
                    if (Math.Abs(sX) > Math.Abs(sY))
                    {
                        switch (sX)
                        {
                            case > 0 when sY > 0:
                            case < 0 when sY < 0:
                                g.DrawEllipse(pen, cX, cY, sX, sX);
                                break;
                            case > 0 when sY < 0:
                                g.DrawEllipse(pen, cX, cY, sX, -sX);
                                break;
                            default:
                                g.DrawEllipse(pen, cX, cY, sX, -sX);
                                break;
                        }
                    }
                    else
                    {
                        switch (sX)
                        {
                            case > 0 when sY > 0:
                            case < 0 when sY < 0:
                                g.DrawEllipse(pen, cX, cY, sY, sY);
                                break;
                            case > 0 when sY < 0:
                                g.DrawEllipse(pen, cX, cY, -sY, sY);
                                break;
                            default:
                                g.DrawEllipse(pen, cX, cY, -sY, sY);
                                break;
                        }
                    }
                    break;
                case Tools.CircleFill:
                    if (Math.Abs(sX) > Math.Abs(sY))
                    {
                        switch (sX)
                        {
                            case > 0 when sY > 0:
                            case < 0 when sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, sX, sX);
                                break;
                            case > 0 when sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, sX, -sX);
                                break;
                            default:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, sX, -sX);
                                break;
                        }
                    }
                    else
                    {
                        switch (sX)
                        {
                            case > 0 when sY > 0:
                            case < 0 when sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, sY, sY);
                                break;
                            case > 0 when sY < 0:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, -sY, sY);
                                break;
                            default:
                                g.FillEllipse(new SolidBrush(Settings.LastUseColor), cX, cY, -sY, sY);
                                break;
                        }
                    }
                    break;


                //IV четверть
                case Tools.Square when sX > 0 && sY > 0 && sX > sY:
                    sY = sX;
                    g.DrawRectangle(pen, cX, cY, sX, sY);
                    break;
                case Tools.Square when sX > 0 && sY > 0 && sX < sY:
                    sX = sY;
                    g.DrawRectangle(pen, cX, cY, sY, sY);
                    break;
                //III четверть
                case Tools.Square when sX < 0 && sY > 0 && -sX > sY:
                    sY = -sX;
                    g.DrawRectangle(pen, cX + sX, cY, -sX, sY);
                    break;
                case Tools.Square when sX < 0 && sY > 0 && -sX < sY:
                    sX = -sY;
                    g.DrawRectangle(pen, cX + sX, cY, -sX, sY);
                    break;
                //I четверть
                case Tools.Square when sX > 0 && sY < 0 && sX > -sY:
                    sY = -sX;
                    g.DrawRectangle(pen, cX, cY + sY, sX, -sY);
                    break;
                case Tools.Square when sX > 0 && sY < 0 && sX < -sY:
                    sX = -sY;
                    g.DrawRectangle(pen, cX, cY + sY, sX, -sY);
                    break;
                //II четверть
                case Tools.Square when sX < 0 && sY < 0 && -sX > -sY:
                    sY = sX;
                    g.DrawRectangle(pen, cX + sX, cY + sY, -sX, -sY);
                    break;
                case Tools.Square when sX < 0 && sY < 0 && -sX < -sY:
                    sX = sY;
                    g.DrawRectangle(pen, cX + sX, cY + sY, -sX, -sY);
                    break;


                
                //IV четверть
                case Tools.SquareFill when sX > 0 && sY > 0 && sX > sY:
                    sY = sX;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX, cY, sX, sY);
                    break;
                case Tools.SquareFill when sX > 0 && sY > 0 && sX < sY:
                    sX = sY;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX, cY, sY, sY);
                    break;
                //III четверть
                case Tools.SquareFill when sX < 0 && sY > 0 && -sX > sY:
                    sY = -sX;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX + sX, cY, -sX, sY);
                    break;
                case Tools.SquareFill when sX < 0 && sY > 0 && -sX < sY:
                    sX = -sY;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX + sX, cY, -sX, sY);
                    break;
                //I четверть
                case Tools.SquareFill when sX > 0 && sY < 0 && sX > -sY:
                    sY = -sX;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX, cY + sY, sX, -sY);
                    break;
                case Tools.SquareFill when sX > 0 && sY < 0 && sX < -sY:
                    sX = -sY;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX, cY + sY, sX, -sY);
                    break;
                //II четверть
                case Tools.SquareFill when sX < 0 && sY < 0 && -sX > -sY:
                    sY = sX;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX + sX, cY + sY, -sX, -sY);
                    break;
                case Tools.SquareFill when sX < 0 && sY < 0 && -sX < -sY:
                    sX = sY;
                    g.FillRectangle(new SolidBrush(Settings.LastUseColor), cX + sX, cY + sY, -sX, -sY);
                    break;
                

                case Tools.Selection when sX >= 0 && sY >= 0:
                    tmp = new Rectangle(cX, cY, sX, sY);
                    g.DrawRectangle(penTmp, tmp);
                    break;
                case Tools.Selection when sX < 0 && sY >= 0:
                    tmp = new Rectangle(cX + sX, cY, Math.Abs(sX), sY);
                    g.DrawRectangle(penTmp, tmp);
                    break;
                case Tools.Selection when sX >= 0 && sY < 0:
                    tmp = new Rectangle(cX, cY + sY, sX, Math.Abs(sY));
                    g.DrawRectangle(penTmp, tmp);
                    break;
                case Tools.Selection when sX < 0 && sY < 0:
                    tmp = new Rectangle(cX + sX, cY + sY, Math.Abs(sX), Math.Abs(sY));
                    g.DrawRectangle(penTmp, tmp);
                    break;

            }

            return tmp;
        }
    }
}

