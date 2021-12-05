﻿global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.Linq;
global using System.Reactive.Disposables;
global using System.Reactive.Linq;
global using System.Reactive.Threading.Tasks;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Components;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.JSInterop;
global using System.Collections.Specialized;

namespace Soatech.Blazor.Leaflet
{
    public static class Extensions
    {
        public static IObservable<PropertyChangedEventArgs> WhenChanged(this INotifyPropertyChanged me)
        {
            return Observable.Create<PropertyChangedEventArgs>(o =>
            {
                void x(object? s, PropertyChangedEventArgs e) => o.OnNext(e);
                me.PropertyChanged += x;
                var result = Disposable.Create(dispose: () => me.PropertyChanged -= x);
                return result;
            });
        }

        public static IObservable<NotifyCollectionChangedEventArgs> WhenCollectionChanged(this INotifyCollectionChanged me)
        {
            return Observable.Create<NotifyCollectionChangedEventArgs>(o =>
            {
                void x(object? s, NotifyCollectionChangedEventArgs e) => o.OnNext(e);
                me.CollectionChanged += x;
                var result = Disposable.Create(dispose: () => me.CollectionChanged -= x);
                return result;
            });
        }

        public static IObservable<PropertyChangedEventArgs> WhenChanged(this INotifyPropertyChanged me, string propertyName)
        {
            return me.WhenChanged().Where(ev => ev.PropertyName == propertyName);
        }

        public static IServiceCollection AddSoatechBlazorComponents(this IServiceCollection services)
        {
            return services;
        }


    }
}