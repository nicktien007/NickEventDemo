using System;

namespace NickEventDemo
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; set; }

        public event EventHandler<UpdatedEventArgs> Updated;

        public class UpdatedEventArgs : EventArgs
        {
            public string Name { get; }
            public UpdatedEventArgs(string name)
            {
                this.Name = name;
            }
        }

        public Product(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
            OnUpdated(new UpdatedEventArgs(name));
        }

        protected virtual void OnUpdated(UpdatedEventArgs e)
        {
            Updated?.Invoke(this, e);
        }
    }
}
