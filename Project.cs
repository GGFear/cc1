/***********************************************************************
 * Module:  Project.cs
 * Author:  secon
 * Purpose: Definition of the Class Project
 ***********************************************************************/

using System;

public class Project
{
   public void StartProject()
   {
      // TODO: implement
   }
   
   public void Completness()
   {
      // TODO: implement
   }

   public System.Collections.ArrayList team;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetTeam()
   {
      if (team == null)
         team = new System.Collections.ArrayList();
      return team;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetTeam(System.Collections.ArrayList newTeam)
   {
      RemoveAllTeam();
      foreach (Team oTeam in newTeam)
         AddTeam(oTeam);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddTeam(Team newTeam)
   {
      if (newTeam == null)
         return;
      if (this.team == null)
         this.team = new System.Collections.ArrayList();
      if (!this.team.Contains(newTeam))
         this.team.Add(newTeam);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveTeam(Team oldTeam)
   {
      if (oldTeam == null)
         return;
      if (this.team != null)
         if (this.team.Contains(oldTeam))
            this.team.Remove(oldTeam);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllTeam()
   {
      if (team != null)
         team.Clear();
   }
   public System.Collections.ArrayList teamLeader;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetTeamLeader()
   {
      if (teamLeader == null)
         teamLeader = new System.Collections.ArrayList();
      return teamLeader;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetTeamLeader(System.Collections.ArrayList newTeamLeader)
   {
      RemoveAllTeamLeader();
      foreach (TeamLeader oTeamLeader in newTeamLeader)
         AddTeamLeader(oTeamLeader);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddTeamLeader(TeamLeader newTeamLeader)
   {
      if (newTeamLeader == null)
         return;
      if (this.teamLeader == null)
         this.teamLeader = new System.Collections.ArrayList();
      if (!this.teamLeader.Contains(newTeamLeader))
         this.teamLeader.Add(newTeamLeader);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveTeamLeader(TeamLeader oldTeamLeader)
   {
      if (oldTeamLeader == null)
         return;
      if (this.teamLeader != null)
         if (this.teamLeader.Contains(oldTeamLeader))
            this.teamLeader.Remove(oldTeamLeader);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllTeamLeader()
   {
      if (teamLeader != null)
         teamLeader.Clear();
   }

   private string NamePr;
   private string Methodology;
   private string PercentOfSales;
   private bool AvailabilityOfDocumentation;
   private bool AvailabilityOfTesting;
   private string SecurityLevel;
   private string Reliability;
   private string Convenience;
   private bool Completion;

}