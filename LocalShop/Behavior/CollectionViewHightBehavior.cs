using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LocalShop.Behavior
{
    public class CollectionViewHightBehavior : Behavior<CollectionView>
    {
        bool hasHeightChanged = false;
        public CollectionView CollectionViewObject
        {
            get;
            private set;
        }
        protected override void OnAttachedTo(CollectionView bindable)
        {
            base.OnAttachedTo(bindable);
            CollectionViewObject = bindable;
            bindable.BindingContextChanged += Bindable_BindingContextChanged;
            bindable.SizeChanged += Bindable_SizeChanged;
        }


        private void Bindable_SizeChanged(object sender, EventArgs e)
        {
            var collectionHeight = CollectionViewObject.Height;

            if (CollectionViewObject.Height > 0 && !hasHeightChanged)
            {
                CollectionViewObject.HeightRequest = (collectionHeight / 2) + 20;

                hasHeightChanged = true;
            }
        }

        private void Bindable_BindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = CollectionViewObject.BindingContext;
        }
        protected override void OnDetachingFrom(CollectionView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= Bindable_BindingContextChanged;
            bindable.SizeChanged -= Bindable_SizeChanged;
        }
    }
}
