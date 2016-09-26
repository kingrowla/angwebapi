/// <reference path="../../typings/globals/core-js/index.d.ts" />


import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { AppComponent } from './app.component';
const platform = platformBrowserDynamic();
platform.bootstrapModule(AppComponent);