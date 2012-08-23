﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TimeTrackerModel", "FK_Task_0", "Project", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SampleApp.ExampleData.Project), "Task", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SampleApp.ExampleData.Task), true)]
[assembly: EdmRelationshipAttribute("TimeTrackerModel", "FK_Work_0", "Task", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(SampleApp.ExampleData.Task), "Work", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(SampleApp.ExampleData.Work), true)]

#endregion

namespace SampleApp.ExampleData
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TTEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TTEntities object using the connection string found in the 'TTEntities' section of the application configuration file.
        /// </summary>
        public TTEntities() : base("name=TTEntities", "TTEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TTEntities object.
        /// </summary>
        public TTEntities(string connectionString) : base(connectionString, "TTEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TTEntities object.
        /// </summary>
        public TTEntities(EntityConnection connection) : base(connection, "TTEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Project> Projects
        {
            get
            {
                if ((_Projects == null))
                {
                    _Projects = base.CreateObjectSet<Project>("Projects");
                }
                return _Projects;
            }
        }
        private ObjectSet<Project> _Projects;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Task> Tasks
        {
            get
            {
                if ((_Tasks == null))
                {
                    _Tasks = base.CreateObjectSet<Task>("Tasks");
                }
                return _Tasks;
            }
        }
        private ObjectSet<Task> _Tasks;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Work> Works
        {
            get
            {
                if ((_Works == null))
                {
                    _Works = base.CreateObjectSet<Work>("Works");
                }
                return _Works;
            }
        }
        private ObjectSet<Work> _Works;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Projects EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProjects(Project project)
        {
            base.AddObject("Projects", project);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tasks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTasks(Task task)
        {
            base.AddObject("Tasks", task);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Works EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToWorks(Work work)
        {
            base.AddObject("Works", work);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTrackerModel", Name="Project")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Project : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Project object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="visible">Initial value of the Visible property.</param>
        public static Project CreateProject(global::System.Int64 id, global::System.String name, global::System.Boolean visible)
        {
            Project project = new Project();
            project.Id = id;
            project.Name = name;
            project.Visible = visible;
            return project;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Visible
        {
            get
            {
                return _Visible;
            }
            set
            {
                OnVisibleChanging(value);
                ReportPropertyChanging("Visible");
                _Visible = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Visible");
                OnVisibleChanged();
            }
        }
        private global::System.Boolean _Visible;
        partial void OnVisibleChanging(global::System.Boolean value);
        partial void OnVisibleChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTrackerModel", "FK_Task_0", "Task")]
        public EntityCollection<Task> Tasks
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Task>("TimeTrackerModel.FK_Task_0", "Task");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Task>("TimeTrackerModel.FK_Task_0", "Task", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTrackerModel", Name="Task")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Task : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Task object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="projectId">Initial value of the ProjectId property.</param>
        /// <param name="visible">Initial value of the Visible property.</param>
        public static Task CreateTask(global::System.Int64 id, global::System.String name, global::System.Int64 projectId, global::System.Boolean visible)
        {
            Task task = new Task();
            task.Id = id;
            task.Name = name;
            task.ProjectId = projectId;
            task.Visible = visible;
            return task;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ProjectId
        {
            get
            {
                return _ProjectId;
            }
            set
            {
                OnProjectIdChanging(value);
                ReportPropertyChanging("ProjectId");
                _ProjectId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProjectId");
                OnProjectIdChanged();
            }
        }
        private global::System.Int64 _ProjectId;
        partial void OnProjectIdChanging(global::System.Int64 value);
        partial void OnProjectIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Visible
        {
            get
            {
                return _Visible;
            }
            set
            {
                OnVisibleChanging(value);
                ReportPropertyChanging("Visible");
                _Visible = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Visible");
                OnVisibleChanged();
            }
        }
        private global::System.Boolean _Visible;
        partial void OnVisibleChanging(global::System.Boolean value);
        partial void OnVisibleChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTrackerModel", "FK_Task_0", "Project")]
        public Project Project
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Project>("TimeTrackerModel.FK_Task_0", "Project").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Project>("TimeTrackerModel.FK_Task_0", "Project").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Project> ProjectReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Project>("TimeTrackerModel.FK_Task_0", "Project");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Project>("TimeTrackerModel.FK_Task_0", "Project", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTrackerModel", "FK_Work_0", "Work")]
        public EntityCollection<Work> Works
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Work>("TimeTrackerModel.FK_Work_0", "Work");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Work>("TimeTrackerModel.FK_Work_0", "Work", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TimeTrackerModel", Name="Work")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Work : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Work object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="taskId">Initial value of the TaskId property.</param>
        /// <param name="duration">Initial value of the Duration property.</param>
        /// <param name="dateOfWork">Initial value of the DateOfWork property.</param>
        public static Work CreateWork(global::System.Int64 id, global::System.Int64 taskId, global::System.Double duration, global::System.DateTime dateOfWork)
        {
            Work work = new Work();
            work.Id = id;
            work.TaskId = taskId;
            work.Duration = duration;
            work.DateOfWork = dateOfWork;
            return work;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int64 _Id;
        partial void OnIdChanging(global::System.Int64 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 TaskId
        {
            get
            {
                return _TaskId;
            }
            set
            {
                OnTaskIdChanging(value);
                ReportPropertyChanging("TaskId");
                _TaskId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TaskId");
                OnTaskIdChanged();
            }
        }
        private global::System.Int64 _TaskId;
        partial void OnTaskIdChanging(global::System.Int64 value);
        partial void OnTaskIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double Duration
        {
            get
            {
                return _Duration;
            }
            set
            {
                OnDurationChanging(value);
                ReportPropertyChanging("Duration");
                _Duration = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Duration");
                OnDurationChanged();
            }
        }
        private global::System.Double _Duration;
        partial void OnDurationChanging(global::System.Double value);
        partial void OnDurationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateOfWork
        {
            get
            {
                return _DateOfWork;
            }
            set
            {
                OnDateOfWorkChanging(value);
                ReportPropertyChanging("DateOfWork");
                _DateOfWork = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateOfWork");
                OnDateOfWorkChanged();
            }
        }
        private global::System.DateTime _DateOfWork;
        partial void OnDateOfWorkChanging(global::System.DateTime value);
        partial void OnDateOfWorkChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TimeTrackerModel", "FK_Work_0", "Task")]
        public Task Task
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Task>("TimeTrackerModel.FK_Work_0", "Task").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Task>("TimeTrackerModel.FK_Work_0", "Task").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Task> TaskReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Task>("TimeTrackerModel.FK_Work_0", "Task");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Task>("TimeTrackerModel.FK_Work_0", "Task", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}