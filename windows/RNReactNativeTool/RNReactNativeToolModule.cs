using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Tool.RNReactNativeTool
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeToolModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeToolModule"/>.
        /// </summary>
        internal RNReactNativeToolModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeTool";
            }
        }
    }
}
