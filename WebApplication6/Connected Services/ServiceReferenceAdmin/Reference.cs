//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.ServiceReferenceAdmin {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/AdminControl")]
    [System.SerializableAttribute()]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/AdminControl")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsActive {
            get {
                return this.IsActiveField;
            }
            set {
                if ((this.IsActiveField.Equals(value) != true)) {
                    this.IsActiveField = value;
                    this.RaisePropertyChanged("IsActive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceAdmin.IAdminControl")]
    public interface IAdminControl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectCategories", ReplyAction="http://tempuri.org/IAdminControl/SelectCategoriesResponse")]
        System.Data.DataSet SelectCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectCategories", ReplyAction="http://tempuri.org/IAdminControl/SelectCategoriesResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/AddCategory", ReplyAction="http://tempuri.org/IAdminControl/AddCategoryResponse")]
        bool AddCategory(WebApplication6.ServiceReferenceAdmin.Category ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/AddCategory", ReplyAction="http://tempuri.org/IAdminControl/AddCategoryResponse")]
        System.Threading.Tasks.Task<bool> AddCategoryAsync(WebApplication6.ServiceReferenceAdmin.Category ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/UpdateCategory", ReplyAction="http://tempuri.org/IAdminControl/UpdateCategoryResponse")]
        bool UpdateCategory(WebApplication6.ServiceReferenceAdmin.Category ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/UpdateCategory", ReplyAction="http://tempuri.org/IAdminControl/UpdateCategoryResponse")]
        System.Threading.Tasks.Task<bool> UpdateCategoryAsync(WebApplication6.ServiceReferenceAdmin.Category ct);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/DeleteCategory", ReplyAction="http://tempuri.org/IAdminControl/DeleteCategoryResponse")]
        bool DeleteCategory(int CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/DeleteCategory", ReplyAction="http://tempuri.org/IAdminControl/DeleteCategoryResponse")]
        System.Threading.Tasks.Task<bool> DeleteCategoryAsync(int CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectCategoryById", ReplyAction="http://tempuri.org/IAdminControl/SelectCategoryByIdResponse")]
        System.Data.DataSet SelectCategoryById(int CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectCategoryById", ReplyAction="http://tempuri.org/IAdminControl/SelectCategoryByIdResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectCategoryByIdAsync(int CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectProducts", ReplyAction="http://tempuri.org/IAdminControl/SelectProductsResponse")]
        System.Data.DataSet SelectProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectProducts", ReplyAction="http://tempuri.org/IAdminControl/SelectProductsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/AddProduct", ReplyAction="http://tempuri.org/IAdminControl/AddProductResponse")]
        bool AddProduct(WebApplication6.ServiceReferenceAdmin.Product pd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/AddProduct", ReplyAction="http://tempuri.org/IAdminControl/AddProductResponse")]
        System.Threading.Tasks.Task<bool> AddProductAsync(WebApplication6.ServiceReferenceAdmin.Product pd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/UpdateProduct", ReplyAction="http://tempuri.org/IAdminControl/UpdateProductResponse")]
        bool UpdateProduct(WebApplication6.ServiceReferenceAdmin.Product pd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/UpdateProduct", ReplyAction="http://tempuri.org/IAdminControl/UpdateProductResponse")]
        System.Threading.Tasks.Task<bool> UpdateProductAsync(WebApplication6.ServiceReferenceAdmin.Product pd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/DeleteProduct", ReplyAction="http://tempuri.org/IAdminControl/DeleteProductResponse")]
        bool DeleteProduct(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/DeleteProduct", ReplyAction="http://tempuri.org/IAdminControl/DeleteProductResponse")]
        System.Threading.Tasks.Task<bool> DeleteProductAsync(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectProductById", ReplyAction="http://tempuri.org/IAdminControl/SelectProductByIdResponse")]
        System.Data.DataSet SelectProductById(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectProductById", ReplyAction="http://tempuri.org/IAdminControl/SelectProductByIdResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectProductByIdAsync(int ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectProductByCategoryId", ReplyAction="http://tempuri.org/IAdminControl/SelectProductByCategoryIdResponse")]
        System.Data.DataSet SelectProductByCategoryId(int CategoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminControl/SelectProductByCategoryId", ReplyAction="http://tempuri.org/IAdminControl/SelectProductByCategoryIdResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SelectProductByCategoryIdAsync(int CategoryId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminControlChannel : WebApplication6.ServiceReferenceAdmin.IAdminControl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminControlClient : System.ServiceModel.ClientBase<WebApplication6.ServiceReferenceAdmin.IAdminControl>, WebApplication6.ServiceReferenceAdmin.IAdminControl {
        
        public AdminControlClient() {
        }
        
        public AdminControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet SelectCategories() {
            return base.Channel.SelectCategories();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCategoriesAsync() {
            return base.Channel.SelectCategoriesAsync();
        }
        
        public bool AddCategory(WebApplication6.ServiceReferenceAdmin.Category ct) {
            return base.Channel.AddCategory(ct);
        }
        
        public System.Threading.Tasks.Task<bool> AddCategoryAsync(WebApplication6.ServiceReferenceAdmin.Category ct) {
            return base.Channel.AddCategoryAsync(ct);
        }
        
        public bool UpdateCategory(WebApplication6.ServiceReferenceAdmin.Category ct) {
            return base.Channel.UpdateCategory(ct);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateCategoryAsync(WebApplication6.ServiceReferenceAdmin.Category ct) {
            return base.Channel.UpdateCategoryAsync(ct);
        }
        
        public bool DeleteCategory(int CategoryId) {
            return base.Channel.DeleteCategory(CategoryId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCategoryAsync(int CategoryId) {
            return base.Channel.DeleteCategoryAsync(CategoryId);
        }
        
        public System.Data.DataSet SelectCategoryById(int CategoryId) {
            return base.Channel.SelectCategoryById(CategoryId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectCategoryByIdAsync(int CategoryId) {
            return base.Channel.SelectCategoryByIdAsync(CategoryId);
        }
        
        public System.Data.DataSet SelectProducts() {
            return base.Channel.SelectProducts();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectProductsAsync() {
            return base.Channel.SelectProductsAsync();
        }
        
        public bool AddProduct(WebApplication6.ServiceReferenceAdmin.Product pd) {
            return base.Channel.AddProduct(pd);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductAsync(WebApplication6.ServiceReferenceAdmin.Product pd) {
            return base.Channel.AddProductAsync(pd);
        }
        
        public bool UpdateProduct(WebApplication6.ServiceReferenceAdmin.Product pd) {
            return base.Channel.UpdateProduct(pd);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProductAsync(WebApplication6.ServiceReferenceAdmin.Product pd) {
            return base.Channel.UpdateProductAsync(pd);
        }
        
        public bool DeleteProduct(int ProductId) {
            return base.Channel.DeleteProduct(ProductId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProductAsync(int ProductId) {
            return base.Channel.DeleteProductAsync(ProductId);
        }
        
        public System.Data.DataSet SelectProductById(int ProductId) {
            return base.Channel.SelectProductById(ProductId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectProductByIdAsync(int ProductId) {
            return base.Channel.SelectProductByIdAsync(ProductId);
        }
        
        public System.Data.DataSet SelectProductByCategoryId(int CategoryId) {
            return base.Channel.SelectProductByCategoryId(CategoryId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SelectProductByCategoryIdAsync(int CategoryId) {
            return base.Channel.SelectProductByCategoryIdAsync(CategoryId);
        }
    }
}
