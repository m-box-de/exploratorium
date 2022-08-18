/* Auto-Generated on 03/28/2022 19:07:32 +00:00 
   GeneratorAssembly = "Directus.Connect.v9";        
   GeneratorAssemblyVersion = "1.3.810.600";

*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Directus.Connect.v9;
using Directus.Connect.v9.Converters;
using Directus.Connect.v9.CodeGeneration;

namespace Directus.Generated
{

    /// <summary>
    /// Content items (aggregations of assets)
    /// </summary>
    [GeneratedRecord("artefacts")]
    public partial class @ArtefactsRecord : DbRecord, IDbRecord    { // start of generated class

        public static explicit operator ArtefactsRecord(long id) => DbRecordUtil.CreateRef<ArtefactsRecord>(id);
        public static explicit operator ArtefactsRecord(string id) => DbRecordUtil.CreateRef<ArtefactsRecord>(id);

        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "id", Required = Required.Default)]
        public System.Int32 @Id { get; set; } // directus type: Integer
      

        [JsonIgnore] public override string __Primary 
        {
            get => @Id.ToString(); 
            set => @Id = int.Parse(value);
        }
        
        [Serializable]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusChoices
        {

            [EnumMember(Value = "published")]
            Published,
            [EnumMember(Value = "draft")]
            Draft,
            [EnumMember(Value = "archived")]
            Archived
        }
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "status", Required = Required.Default)]
        public StatusChoices @Status { get; set; } // directus type: String
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "sort", Required = Required.Default)]
        public System.Int32 @Sort { get; set; } // directus type: Integer
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "user_created", Required = Required.Default)]
        [JsonConverter(typeof(DbRecordReferenceConverter<DirectusUser>))]  
        public DirectusUser @UserCreated { get; set; } // directus type: Uuid
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "date_created", Required = Required.Default)]
        public System.DateTimeOffset @DateCreated { get; set; } // directus type: Timestamp
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "user_updated", Required = Required.Default)]
        [JsonConverter(typeof(DbRecordReferenceConverter<DirectusUser>))]  
        public DirectusUser @UserUpdated { get; set; } // directus type: Uuid
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "date_updated", Required = Required.Default)]
        public System.DateTimeOffset @DateUpdated { get; set; } // directus type: Timestamp
        
        /// <summary>
        /// Ein kurzer beschreibender Name zur Identifizierung eines Datensatzes.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "name", Required = Required.Default)]
        public System.String @Name { get; set; } // directus type: String
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "thumbnail", Required = Required.Default)]
        [JsonConverter(typeof(DbRecordReferenceConverter<DirectusFile>))]  
        public DirectusFile @Thumbnail { get; set; } // directus type: Uuid
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "section", Required = Required.Default)]
        [JsonConverter(typeof(DbRecordReferenceConverter<SectionsRecord>))]  
        public SectionsRecord @Section { get; set; } // directus type: Integer
        
        [Serializable]
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutChoices
        {

            [EnumMember(Value = "video")]
            Video,
            [EnumMember(Value = "slideshow")]
            Slideshow,
            [EnumMember(Value = "model")]
            Model
        }
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "layout", Required = Required.Default)]
        public LayoutChoices @Layout { get; set; } // directus type: String
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "topic", Required = Required.Default)]
        [JsonConverter(typeof(DbRecordReferenceConverter<SectionsRecord>))]  
        public SectionsRecord @Topic { get; set; } // directus type: Integer
        
        /// <summary>
        /// Dieser Wert beeinflusst die Priorität, die dieser Artikel hat, wenn er als Teil einer Sammlung von Artikeln angezeigt wird. Ein höherer Wert bedeutet, dass dieser Artikel prominenter platziert wird.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "priority", Required = Required.Default)]
        public System.Int32 @Priority { get; set; } // directus type: Integer
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "persons", Required = Required.Default)]
        [JsonIgnore] public PersonsArtefactsRecord[] __PersonsJunction { get; set; } // directus type: ManyToMany
        [JsonIgnore] public PersonsRecord[] @Persons => __PersonsCache ?? (__PersonsCache = __PersonsJunction?.Select(it => it.PersonsId).ToArray());
        [JsonIgnore] private PersonsRecord[] __PersonsCache;
        
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "assets", Required = Required.Default)]
        [JsonIgnore] public AssetsArtefactsRecord[] __AssetsJunction { get; set; } // directus type: ManyToMany
        [JsonIgnore] public AssetsRecord[] @Assets => __AssetsCache ?? (__AssetsCache = __AssetsJunction?.Select(it => it.AssetsId).ToArray());
        [JsonIgnore] private AssetsRecord[] __AssetsCache;
        
        
        /// <summary>
        /// Objekttitel und -beschreibungen in Sprachen
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "translations", Required = Required.Default)]
        public Translations<ArtefactsTranslationsRecord> @Translations { get; set; } // directus type: Translations
        
        /// <summary>
        /// No comment.
        /// </summary>
        /// <remarks>
        /// <para>Field declaration:
        /// <code>
        /// {
        /// </code></para>
        /// </remarks>

        [JsonProperty(PropertyName = "tags", Required = Required.Default)]
        [JsonIgnore] public ArtefactsTags1Record[] __TagsJunction { get; set; } // directus type: ManyToMany
        [JsonIgnore] public TagsRecord[] @Tags => __TagsCache ?? (__TagsCache = __TagsJunction?.Select(it => it.TagsId).ToArray());
        [JsonIgnore] private TagsRecord[] __TagsCache;
        
       
        [JsonIgnore] public string __Table => "artefacts";
        [JsonIgnore] public static Type __TypeOfSelf => typeof(ArtefactsRecord);
    } // end of generated class
}
