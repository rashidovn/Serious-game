﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeriousGameLib;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Kantoor3D.GameObjects
{
    public class TafelUitnodiging : GameObject3D
    {
        public TafelUitnodiging()
        {

            Model = Content.Load<Model>(@"Kantoor3D\Models\Buro_3DWereld_Ready");
            Position = new Vector3(6.5f, 0.0f, 9.8f);

            BoundingBoxScale = new Vector3(0.35f, 0.3f, 0.77f);
            BoundingBoxOffset = new Vector3(0.25f, 0.8f, -0.15f);

            MiniGameType = MiniGames.UITNODIGING;
            MiniGameAngle = new Vector3(0, -90, 0); // Look down at the table.
            MiniGamePosition = new Vector3(Position.X, Position.Y + 6, Position.Z); // Hover slightly above the table.

            RotateY = 90;
        }
    }
}
