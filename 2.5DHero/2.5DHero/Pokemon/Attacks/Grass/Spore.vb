﻿Namespace BattleSystem.Moves.Grass

    Public Class Spore

        Inherits Attack

        Public Sub New()
            '#Definitions
            Me.Type = New Element(Element.Types.Grass)
            Me.ID = 147
            Me.OriginalPP = 15
            Me.CurrentPP = 15
            Me.MaxPP = 15
            Me.Power = 0
            Me.Accuracy = 100
            Me.Category = Categories.Status
            Me.ContestCategory = ContestCategories.Beauty
            Me.Name = "Spore"
            Me.Description = "The user scatters bursts of spores that induce sleep."
            Me.CriticalChance = 0
            Me.IsHMMove = False
            Me.Target = Targets.OneAdjacentTarget
            Me.Priority = 0
            Me.TimesToAttack = 1
            '#End

            '#SpecialDefinitions
            Me.MakesContact = False
            Me.ProtectAffected = True
            Me.MagicCoatAffected = True
            Me.SnatchAffected = False
            Me.MirrorMoveAffected = True
            Me.KingsrockAffected = False
            Me.CounterAffected = False
            Me.DisabledWhileGravity = False
            Me.UseEffectiveness = False
            Me.IsHealingMove = False
            Me.RemovesFrozen = False
            Me.IsRecoilMove = False
            Me.IsPunchingMove = False
            Me.ImmunityAffected = True
            Me.IsDamagingMove = False
            Me.IsProtectMove = False
            Me.IsSoundMove = False
            Me.HasSecondaryEffect = False
            Me.IsAffectedBySubstitute = True
            Me.IsOneHitKOMove = False
            Me.IsWonderGuardAffected = False
            Me.IsPowderMove = True
            '#End

            Me.AIField1 = AIField.Sleep
            Me.AIField2 = AIField.Nothing
        End Sub

        Public Overrides Sub MoveHits(own As Boolean, BattleScreen As BattleScreen)
            If BattleScreen.Battle.InflictSleep(Not own, own, BattleScreen, -1, "", "move:spore") = False Then
                BattleScreen.BattleQuery.Add(New TextQueryObject(Me.Name & " failed!"))
            End If
        End Sub

    End Class

End Namespace
