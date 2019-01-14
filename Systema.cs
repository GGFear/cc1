/***********************************************************************
 * Module:  Systema.cs
 * Author:  secon
 * Purpose: Definition of the Class Systema
 ***********************************************************************/

using System;

public class Systema
{
   public void ProjectCheckForCompletness()
   {
      // TODO: implement
   }
   
   public void Start()
   {
      // TODO: implement
   }

   public System.Collections.ArrayList planning;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetPlanning()
   {
      if (planning == null)
         planning = new System.Collections.ArrayList();
      return planning;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetPlanning(System.Collections.ArrayList newPlanning)
   {
      RemoveAllPlanning();
      foreach (Planning oPlanning in newPlanning)
         AddPlanning(oPlanning);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddPlanning(Planning newPlanning)
   {
      if (newPlanning == null)
         return;
      if (this.planning == null)
         this.planning = new System.Collections.ArrayList();
      if (!this.planning.Contains(newPlanning))
         this.planning.Add(newPlanning);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemovePlanning(Planning oldPlanning)
   {
      if (oldPlanning == null)
         return;
      if (this.planning != null)
         if (this.planning.Contains(oldPlanning))
            this.planning.Remove(oldPlanning);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllPlanning()
   {
      if (planning != null)
         planning.Clear();
   }
   public System.Collections.ArrayList manager;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetManager()
   {
      if (manager == null)
         manager = new System.Collections.ArrayList();
      return manager;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetManager(System.Collections.ArrayList newManager)
   {
      RemoveAllManager();
      foreach (Manager oManager in newManager)
         AddManager(oManager);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddManager(Manager newManager)
   {
      if (newManager == null)
         return;
      if (this.manager == null)
         this.manager = new System.Collections.ArrayList();
      if (!this.manager.Contains(newManager))
         this.manager.Add(newManager);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveManager(Manager oldManager)
   {
      if (oldManager == null)
         return;
      if (this.manager != null)
         if (this.manager.Contains(oldManager))
            this.manager.Remove(oldManager);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllManager()
   {
      if (manager != null)
         manager.Clear();
   }
   public System.Collections.ArrayList client;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetClient()
   {
      if (client == null)
         client = new System.Collections.ArrayList();
      return client;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetClient(System.Collections.ArrayList newClient)
   {
      RemoveAllClient();
      foreach (Client oClient in newClient)
         AddClient(oClient);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddClient(Client newClient)
   {
      if (newClient == null)
         return;
      if (this.client == null)
         this.client = new System.Collections.ArrayList();
      if (!this.client.Contains(newClient))
         this.client.Add(newClient);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveClient(Client oldClient)
   {
      if (oldClient == null)
         return;
      if (this.client != null)
         if (this.client.Contains(oldClient))
            this.client.Remove(oldClient);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllClient()
   {
      if (client != null)
         client.Clear();
   }
   public System.Collections.ArrayList project;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetProject()
   {
      if (project == null)
         project = new System.Collections.ArrayList();
      return project;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetProject(System.Collections.ArrayList newProject)
   {
      RemoveAllProject();
      foreach (Project oProject in newProject)
         AddProject(oProject);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddProject(Project newProject)
   {
      if (newProject == null)
         return;
      if (this.project == null)
         this.project = new System.Collections.ArrayList();
      if (!this.project.Contains(newProject))
         this.project.Add(newProject);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveProject(Project oldProject)
   {
      if (oldProject == null)
         return;
      if (this.project != null)
         if (this.project.Contains(oldProject))
            this.project.Remove(oldProject);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllProject()
   {
      if (project != null)
         project.Clear();
   }

   private int NumberOfProjects;
   private int NumberOfFinishedProjects;
   private int NumberOfUnfinishedProjects;

}