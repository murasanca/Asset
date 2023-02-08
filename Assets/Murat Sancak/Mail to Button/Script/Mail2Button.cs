// Murat Sancak

namespace murasanca
{
    [UnityEngine.RequireComponent(typeof(UnityEngine.UI.Button))]
    public class Mail2Button:UnityEngine.MonoBehaviour
    {
        /// <summary>
        /// Mail
        /// </summary>
        [UnityEngine.Space(8),UnityEngine.Header("Mail Info"),UnityEngine.SerializeField,UnityEngine.Space(8)]
        private string mail;
        /// <summary>
        /// Subject
        /// </summary>
        [UnityEngine.SerializeField,UnityEngine.Space(8)]
        private string subject;
        /// <summary>
        /// Body
        /// </summary>
        [UnityEngine.SerializeField,UnityEngine.Space(8),UnityEngine.TextArea]
        private string body;

        /// <summary>
        /// Header
        /// </summary>
        [UnityEngine.Space(8),UnityEngine.Header("System Info"),UnityEngine.SerializeField,UnityEngine.Space(8)]
        private string header="System Info";
        /// <summary>
        /// System Info
        /// </summary>
        [UnityEngine.SerializeField,UnityEngine.Space(8)]
        private bool
            batteryLevel=true,
            batteryStatus=true,
            computeSubGroupSize=true,
            constantBufferOffsetAlignment=true,
            copyTextureSupport=true,
            deviceModel=true,
            deviceName=true,
            deviceType=true,
            deviceUniqueIdentifier=true,
            foveatedRenderingCaps=true,
            graphicsDeviceID=true,
            graphicsDeviceName=true,
            graphicsDeviceType=true,
            graphicsDeviceVendor=true,
            graphicsDeviceVendorID=true,
            graphicsDeviceVersion=true,
            graphicsMemorySize=true,
            graphicsMultiThreaded=true,
            graphicsShaderLevel=true,
            graphicsUVStartsAtTop=true,
            hasDynamicUniformArrayIndexingInFragmentShaders=true,
            hasHiddenSurfaceRemovalOnGPU=true,
            hasMipMaxLevel=true,
            hdrDisplaySupportFlags=true,
            maxAnisotropyLevel=true,
            maxComputeBufferInputsCompute=true,
            maxComputeBufferInputsDomain=true,
            maxComputeBufferInputsFragment=true,
            maxComputeBufferInputsGeometry=true,
            maxComputeBufferInputsHull=true,
            maxComputeBufferInputsVertex=true,
            maxComputeWorkGroupSize=true,
            maxComputeWorkGroupSizeX=true,
            maxComputeWorkGroupSizeY=true,
            maxComputeWorkGroupSizeZ=true,
            maxConstantBufferSize=true,
            maxCubemapSize=true,
            maxGraphicsBufferSize=true,
            maxTexture3DSize=true,
            maxTextureArraySlices=true,
            maxTextureSize=true,
            npotSupport=true,
            operatingSystem=true,
            operatingSystemFamily=true,
            processorCount=true,
            processorFrequency=true,
            processorType=true,
            renderingThreadingMode=true,
            supportedRandomWriteTargetCount=true,
            supportedRenderTargetCount=true,
            supports2DArrayTextures=true,
            supports32bitsIndexBuffer=true,
            supports3DRenderTextures=true,
            supports3DTextures=true,
            supportsAccelerometer=true,
            supportsAnisotropicFilter=true,
            supportsAsyncCompute=true,
            supportsAsyncGPUReadback=true,
            supportsAudio=true,
            supportsCompressed3DTextures=true,
            supportsComputeShaders=true,
            supportsConservativeRaster=true,
            supportsCubemapArrayTextures=true,
            supportsGeometryShaders=true,
            supportsGpuRecorder=true,
            supportsGraphicsFence=true,
            supportsGyroscope=true,
            supportsHardwareQuadTopology=true,
            supportsIndirectArgumentsBuffer=true,
            supportsInlineRayTracing=true,
            supportsInstancing=true,
            supportsLocationService=true,
            supportsMipStreaming=true,
            supportsMotionVectors=true,
            supportsMultisampleAutoResolve=true,
            supportsMultisampleResolveDepth=true,
            supportsMultisampleResolveStencil=true,
            supportsMultisampled2DArrayTextures=true,
            supportsMultisampledTextures=true,
            supportsMultiview=true,
            supportsRawShadowDepthSampling=true,
            supportsRayTracing=true,
            supportsRayTracingShaders=true,
            supportsRenderTargetArrayIndexFromVertexShader=true,
            supportsSeparatedRenderTargetsBlend=true,
            supportsSetConstantBuffer=true,
            supportsShadows=true,
            supportsSparseTextures=true,
            supportsStoreAndResolveAction=true,
            supportsTessellationShaders=true,
            supportsTextureWrapMirrorOnce=true,
            supportsVibration=true,
            systemMemorySize=true,
            unsupportedIdentifier=true,
            usesLoadStoreActions=true,
            usesReversedZBuffer=true;
        
        private void Awake()
        {
            if(!string.IsNullOrEmpty(mail))
                GetComponent<UnityEngine.UI.Button>().onClick.AddListener
                (
                    delegate
                    {
                        UnityEngine.Application.OpenURL
                        (
                            string.Concat
                            (
                                "mailto:",mail,
                                "?subject=",string.IsNullOrEmpty(subject)?subject=UnityEngine.Application.productName:subject,
                                "&body=",body,
                                "%0A%0A",
                                string.IsNullOrEmpty(header)?null:string.Concat("%0A%0A%0A",header,"%0A"),
                                // Battery
                                batteryLevel||batteryStatus?
                                    string.Concat
                                    (
                                        "%0A",
                                        batteryLevel?string.Concat("%0ABattery Level: ",UnityEngine.SystemInfo.batteryLevel):null,
                                        batteryStatus?string.Concat("%0ABattery Status: ",UnityEngine.SystemInfo.batteryStatus):null
                                    ):null,
                                // Compute Sub Group Size
                                computeSubGroupSize?string.Concat("%0A%0ACompute Sub Group Size: ",UnityEngine.SystemInfo.computeSubGroupSize):null,
                                // Constant Buffer Offset Alignment
                                constantBufferOffsetAlignment?string.Concat("%0A%0AConstant Buffer Offset Alignment: ",UnityEngine.SystemInfo.constantBufferOffsetAlignment):null,
                                // Copy Texture Support
                                copyTextureSupport?string.Concat("%0A%0ACopy Texture Support: ",UnityEngine.SystemInfo.copyTextureSupport):null,
                                // Device
                                deviceModel||deviceName||deviceType||deviceUniqueIdentifier?
                                    string.Concat
                                    (
                                        "%0A",
                                        deviceModel?string.Concat("%0ADevice Model: ",UnityEngine.SystemInfo.deviceModel):null,
                                        deviceName?string.Concat("%0ADevice Name: ",UnityEngine.SystemInfo.deviceName):null,
                                        deviceType?string.Concat("%0ADevice Type: ",UnityEngine.SystemInfo.deviceType):null,
                                        deviceUniqueIdentifier?string.Concat("%0ADevice Unique Identifier: ",UnityEngine.SystemInfo.deviceUniqueIdentifier):null
                                    ):null,
                                // Foveated Rendering Caps
                                foveatedRenderingCaps?
                                    string.Concat("%0A%0AFoveated Rendering Caps: ",UnityEngine.SystemInfo.foveatedRenderingCaps):null,
                                // Graphics
                                graphicsDeviceID||graphicsDeviceName||graphicsDeviceType||graphicsDeviceVendor||graphicsDeviceVendorID||graphicsDeviceVersion||graphicsMemorySize||graphicsMultiThreaded||graphicsShaderLevel||graphicsUVStartsAtTop?
                                    string.Concat
                                    (
                                        "%0A",
                                        graphicsDeviceID?string.Concat("%0AGraphics Device ID: ",UnityEngine.SystemInfo.graphicsDeviceID):null,
                                        graphicsDeviceName?string.Concat("%0AGraphics Device Name: ",UnityEngine.SystemInfo.graphicsDeviceName):null,
                                        graphicsDeviceType?string.Concat("%0AGraphics Device Type: ",UnityEngine.SystemInfo.graphicsDeviceType):null,
                                        graphicsDeviceVendor?string.Concat("%0AGraphics Device Vendor: ",UnityEngine.SystemInfo.graphicsDeviceVendor):null,
                                        graphicsDeviceVendorID?string.Concat("%0AGraphics Device Vendor ID: ",UnityEngine.SystemInfo.graphicsDeviceVendorID):null,
                                        graphicsDeviceVersion?string.Concat("%0AGraphics Device Version: ",UnityEngine.SystemInfo.graphicsDeviceVersion):null,
                                        graphicsMemorySize?string.Concat("%0AGraphics Memory Size: ",UnityEngine.SystemInfo.graphicsMemorySize):null,
                                        graphicsMultiThreaded?string.Concat("%0AGraphics Multi Threaded: ",UnityEngine.SystemInfo.graphicsMultiThreaded):null,
                                        graphicsShaderLevel?string.Concat("%0AGraphics Shader Level: ",UnityEngine.SystemInfo.graphicsShaderLevel):null,
                                        graphicsUVStartsAtTop?string.Concat("%0AGraphics UV Starts At Top: ",UnityEngine.SystemInfo.graphicsUVStartsAtTop):null
                                    ):null,
                                // Has
                                hasDynamicUniformArrayIndexingInFragmentShaders||hasHiddenSurfaceRemovalOnGPU||hasMipMaxLevel?
                                    string.Concat
                                    (
                                        "%0A",
                                        hasDynamicUniformArrayIndexingInFragmentShaders?string.Concat("%0AHas Dynamic Uniform Array Indexing In Fragment Shaders: ",UnityEngine.SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders):null,
                                        hasHiddenSurfaceRemovalOnGPU?string.Concat("%0AHas Hidden Surface Removal On GPU: ",UnityEngine.SystemInfo.hasHiddenSurfaceRemovalOnGPU):null,
                                        hasMipMaxLevel?string.Concat("%0AHas Mip Max Level: ",UnityEngine.SystemInfo.hasMipMaxLevel):null
                                    ):null,
                                // Hdr Display Support Flags
                                hdrDisplaySupportFlags?string.Concat("%0A%0AHdr Display Support Flags: ",UnityEngine.SystemInfo.hdrDisplaySupportFlags):null,
                                // Max
                                maxAnisotropyLevel||maxComputeBufferInputsCompute||maxComputeBufferInputsDomain||maxComputeBufferInputsFragment||maxComputeBufferInputsGeometry||maxComputeBufferInputsHull||maxComputeBufferInputsVertex||maxComputeWorkGroupSize||maxComputeWorkGroupSizeX||maxComputeWorkGroupSizeY||maxComputeWorkGroupSizeZ||maxConstantBufferSize||maxCubemapSize||maxGraphicsBufferSize||maxTexture3DSize||maxTextureArraySlices||maxTextureSize?
                                    string.Concat
                                    (
                                        "%0A",
                                        maxAnisotropyLevel?string.Concat("%0AMax Anisotropy Level: ",UnityEngine.SystemInfo.maxAnisotropyLevel):null,
                                        maxComputeBufferInputsCompute?string.Concat("%0AMax Compute Buffer Inputs Compute: ",UnityEngine.SystemInfo.maxComputeBufferInputsCompute):null,
                                        maxComputeBufferInputsDomain?string.Concat("%0AMax Compute Buffer Inputs Domain: ",UnityEngine.SystemInfo.maxComputeBufferInputsDomain):null,
                                        maxComputeBufferInputsFragment?string.Concat("%0AMax Compute Buffer Inputs Fragment: ",UnityEngine.SystemInfo.maxComputeBufferInputsFragment):null,
                                        maxComputeBufferInputsGeometry?string.Concat("%0AMax Compute Buffer Inputs Geometry: ",UnityEngine.SystemInfo.maxComputeBufferInputsGeometry):null,
                                        maxComputeBufferInputsHull?string.Concat("%0AMax Compute Buffer Inputs Hull: ",UnityEngine.SystemInfo.maxComputeBufferInputsHull):null,
                                        maxComputeBufferInputsVertex?string.Concat("%0AMax Compute Buffer Inputs Vertex: ",UnityEngine.SystemInfo.maxComputeBufferInputsVertex):null,
                                        maxComputeWorkGroupSize?string.Concat("%0AMax Compute Work Group Size: ",UnityEngine.SystemInfo.maxComputeWorkGroupSize):null,
                                        maxComputeWorkGroupSizeX?string.Concat("%0AMax Compute Work Group Size X: ",UnityEngine.SystemInfo.maxComputeWorkGroupSizeX):null,
                                        maxComputeWorkGroupSizeY?string.Concat("%0AMax Compute Work Group Size Y: ",UnityEngine.SystemInfo.maxComputeWorkGroupSizeY):null,
                                        maxComputeWorkGroupSizeZ?string.Concat("%0AMax Compute Work Group Size Z: ",UnityEngine.SystemInfo.maxComputeWorkGroupSizeZ):null,
                                        maxConstantBufferSize?string.Concat("%0AMax Constant Buffer Size: ",UnityEngine.SystemInfo.maxConstantBufferSize):null,
                                        maxCubemapSize?string.Concat("%0AMax Cubemap Size: ",UnityEngine.SystemInfo.maxCubemapSize):null,
                                        maxGraphicsBufferSize?string.Concat("%0AMax Graphics Buffer Size: ",UnityEngine.SystemInfo.maxGraphicsBufferSize):null,
                                        maxTexture3DSize?string.Concat("%0AMax Texture 3D Size: ",UnityEngine.SystemInfo.maxTexture3DSize):null,
                                        maxTextureArraySlices?string.Concat("%0AMax Texture Array Slices: ",UnityEngine.SystemInfo.maxTextureArraySlices):null,
                                        maxTextureSize?string.Concat("%0AMax Texture Size: ",UnityEngine.SystemInfo.maxTextureSize):null
                                    ):null,
                                // Npot Support
                                npotSupport?string.Concat("%0A%0ANpot Support: ",UnityEngine.SystemInfo.npotSupport):null,
                                // Operating System
                                operatingSystem||operatingSystemFamily?
                                    string.Concat
                                    (
                                        "%0A",
                                        operatingSystem?string.Concat("%0AOperating System: ",UnityEngine.SystemInfo.operatingSystem):null,
                                        operatingSystemFamily?string.Concat("%0AOperating System Family: ",UnityEngine.SystemInfo.operatingSystemFamily):null
                                    ):null,
                                // Processor
                                processorCount||processorFrequency||processorType?
                                    string.Concat
                                    (
                                        "%0A",
                                        processorCount?string.Concat("%0AProcessor Count: ",UnityEngine.SystemInfo.processorCount):null,
                                        processorFrequency?string.Concat("%0AProcessor Frequency: ",UnityEngine.SystemInfo.processorFrequency):null,
                                        processorType?string.Concat("%0AProcessor Type: ",UnityEngine.SystemInfo.processorType):null
                                    ):null,
                                // Rendering Threading Mode
                                renderingThreadingMode?string.Concat("%0A%0ARendering Threading Mode: ",UnityEngine.SystemInfo.renderingThreadingMode):null,
                                // Supported
                                supportedRandomWriteTargetCount||supportedRenderTargetCount?
                                    string.Concat
                                    (
                                        "%0A",
                                        supportedRandomWriteTargetCount?string.Concat("%0ASupported Random Write Target Count: ",UnityEngine.SystemInfo.supportedRandomWriteTargetCount):null,
                                        supportedRenderTargetCount?string.Concat("%0ASupported Render Target Count: ",UnityEngine.SystemInfo.supportedRenderTargetCount):null
                                    ):null,
                                // Supports
                                supports2DArrayTextures||supports32bitsIndexBuffer||supports3DRenderTextures||supports3DTextures||supportsAccelerometer||supportsAnisotropicFilter||supportsAsyncCompute||supportsAsyncGPUReadback||supportsAudio||supportsCompressed3DTextures||supportsComputeShaders||supportsConservativeRaster||supportsCubemapArrayTextures||supportsGeometryShaders||supportsGpuRecorder||supportsGraphicsFence||supportsGyroscope||supportsHardwareQuadTopology||supportsIndirectArgumentsBuffer||supportsInlineRayTracing||supportsInstancing||supportsLocationService||supportsMipStreaming||supportsMotionVectors||supportsMultisampleAutoResolve||supportsMultisampleResolveDepth||supportsMultisampleResolveStencil||supportsMultisampled2DArrayTextures||supportsMultisampledTextures||supportsMultiview||supportsRawShadowDepthSampling||supportsRayTracing||supportsRayTracingShaders||supportsRenderTargetArrayIndexFromVertexShader||supportsSeparatedRenderTargetsBlend||supportsSetConstantBuffer||supportsShadows||supportsSparseTextures||supportsStoreAndResolveAction||supportsTessellationShaders||supportsTextureWrapMirrorOnce||supportsVibration?
                                    string.Concat
                                    (
                                        "%0A",
                                        supports2DArrayTextures?string.Concat("%0ASupports 2D Array Textures: ",UnityEngine.SystemInfo.supports2DArrayTextures):null,
                                        supports32bitsIndexBuffer?string.Concat("%0ASupports 32bits Index Buffer: ",UnityEngine.SystemInfo.supports32bitsIndexBuffer):null,
                                        supports3DRenderTextures?string.Concat("%0ASupports 3D Render Textures: ",UnityEngine.SystemInfo.supports3DRenderTextures):null,
                                        supports3DTextures?string.Concat("%0ASupports 3D Textures: ",UnityEngine.SystemInfo.supports3DTextures):null,
                                        supportsAccelerometer?string.Concat("%0ASupports Accelerometer: ",UnityEngine.SystemInfo.supportsAccelerometer):null,
                                        supportsAnisotropicFilter?string.Concat("%0ASupports Anisotropic Filter: ",UnityEngine.SystemInfo.supportsAnisotropicFilter):null,
                                        supportsAsyncCompute?string.Concat("%0ASupports Async Compute: ",UnityEngine.SystemInfo.supportsAsyncCompute):null,
                                        supportsAsyncGPUReadback?string.Concat("%0ASupports Async GPU Readback: ",UnityEngine.SystemInfo.supportsAsyncGPUReadback):null,
                                        supportsAudio?string.Concat("%0ASupports Audio: ",UnityEngine.SystemInfo.supportsAudio):null,
                                        supportsCompressed3DTextures?string.Concat("%0ASupports Compressed 3D Textures: ",UnityEngine.SystemInfo.supportsCompressed3DTextures):null,
                                        supportsComputeShaders?string.Concat("%0ASupports Compute Shaders: ",UnityEngine.SystemInfo.supportsComputeShaders):null,
                                        supportsConservativeRaster?string.Concat("%0ASupports Conservative Raster: ",UnityEngine.SystemInfo.supportsConservativeRaster):null,
                                        supportsCubemapArrayTextures?string.Concat("%0ASupports Cubemap Array Textures: ",UnityEngine.SystemInfo.supportsCubemapArrayTextures):null,
                                        supportsGeometryShaders?string.Concat("%0ASupports Geometry Shaders: ",UnityEngine.SystemInfo.supportsGeometryShaders):null,
                                        supportsGpuRecorder?string.Concat("%0ASupports Gpu Recorder: ",UnityEngine.SystemInfo.supportsGpuRecorder):null,
                                        supportsGraphicsFence?string.Concat("%0ASupports Graphics Fence: ",UnityEngine.SystemInfo.supportsGraphicsFence):null,
                                        supportsGyroscope?string.Concat("%0ASupports Gyroscope: ",UnityEngine.SystemInfo.supportsGyroscope):null,
                                        supportsHardwareQuadTopology?string.Concat("%0ASupports Hardware Quad Topology: ",UnityEngine.SystemInfo.supportsHardwareQuadTopology):null,
                                        supportsIndirectArgumentsBuffer?string.Concat("%0ASupports Indirect Arguments Buffer: ",UnityEngine.SystemInfo.supportsIndirectArgumentsBuffer):null,
                                        supportsInlineRayTracing?string.Concat("%0ASupports Inline Ray Tracing: ",UnityEngine.SystemInfo.supportsInlineRayTracing):null,
                                        supportsInstancing?string.Concat("%0ASupports Instancing: ",UnityEngine.SystemInfo.supportsInstancing):null,
                                        supportsLocationService?string.Concat("%0ASupports Location Service: ",UnityEngine.SystemInfo.supportsLocationService):null,
                                        supportsMipStreaming?string.Concat("%0ASupports Mip Streaming: ",UnityEngine.SystemInfo.supportsMipStreaming):null,
                                        supportsMotionVectors?string.Concat("%0ASupports Motion Vectors: ",UnityEngine.SystemInfo.supportsMotionVectors):null,
                                        supportsMultisampleAutoResolve?string.Concat("%0ASupports Multisample Auto Resolve: ",UnityEngine.SystemInfo.supportsMultisampleAutoResolve):null,
                                        supportsMultisampleResolveDepth?string.Concat("%0ASupports Multisample Resolve Depth: ",UnityEngine.SystemInfo.supportsMultisampleResolveDepth):null,
                                        supportsMultisampleResolveStencil?string.Concat("%0ASupports Multisample Resolve Stencil: ",UnityEngine.SystemInfo.supportsMultisampleResolveStencil):null,
                                        supportsMultisampled2DArrayTextures?string.Concat("%0ASupports Multisampled 2D Array Textures: ",UnityEngine.SystemInfo.supportsMultisampled2DArrayTextures):null,
                                        supportsMultisampledTextures?string.Concat("%0ASupports Multisampled Textures: ",UnityEngine.SystemInfo.supportsMultisampledTextures):null,
                                        supportsMultiview?string.Concat("%0ASupports Multiview: ",UnityEngine.SystemInfo.supportsMultiview):null,
                                        supportsRawShadowDepthSampling?string.Concat("%0ASupports Raw Shadow Depth Sampling: ",UnityEngine.SystemInfo.supportsRawShadowDepthSampling):null,
                                        supportsRayTracing?string.Concat("%0ASupports Ray Tracing: ",UnityEngine.SystemInfo.supportsRayTracing):null,
                                        supportsRayTracingShaders?string.Concat("%0ASupports Ray Tracing Shaders: ",UnityEngine.SystemInfo.supportsRayTracingShaders):null,
                                        supportsRenderTargetArrayIndexFromVertexShader?string.Concat("%0ASupports Render Target Array Index From Vertex Shader: ",UnityEngine.SystemInfo.supportsRenderTargetArrayIndexFromVertexShader):null,
                                        supportsSeparatedRenderTargetsBlend?string.Concat("%0ASupports Separated Render Targets Blend: ",UnityEngine.SystemInfo.supportsSeparatedRenderTargetsBlend):null,
                                        supportsSetConstantBuffer?string.Concat("%0ASupports Set Constant Buffer: ",UnityEngine.SystemInfo.supportsSetConstantBuffer):null,
                                        supportsShadows?string.Concat("%0ASupports Shadows: ",UnityEngine.SystemInfo.supportsShadows):null,
                                        supportsSparseTextures?string.Concat("%0ASupports Sparse Textures: ",UnityEngine.SystemInfo.supportsSparseTextures):null,
                                        supportsStoreAndResolveAction?string.Concat("%0ASupports Store And Resolve Action: ",UnityEngine.SystemInfo.supportsStoreAndResolveAction):null,
                                        supportsTessellationShaders?string.Concat("%0ASupports Tessellation Shaders: ",UnityEngine.SystemInfo.supportsTessellationShaders):null,
                                        supportsTextureWrapMirrorOnce?string.Concat("%0ASupports Texture Wrap Mirror Once: ",UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce):null,
                                        supportsVibration?string.Concat("%0ASupports Vibration: ",UnityEngine.SystemInfo.supportsVibration):null
                                    ):null,
                                // System Memory Size
                                systemMemorySize?string.Concat("%0A%0ASystem Memory Size: ",UnityEngine.SystemInfo.systemMemorySize):null,
                                // Unsupported Identifier
                                unsupportedIdentifier?string.Concat("%0A%0AUnsupported Identifier: ",UnityEngine.SystemInfo.unsupportedIdentifier):null,
                                // Uses Load Store Actions
                                usesLoadStoreActions||usesReversedZBuffer?
                                    string.Concat
                                    (
                                        "%0A",
                                        usesLoadStoreActions?string.Concat("%0AUses Load Store Actions: ",UnityEngine.SystemInfo.usesLoadStoreActions):null,
                                        usesReversedZBuffer?string.Concat("%0AUses Reversed Z Buffer: ",UnityEngine.SystemInfo.usesReversedZBuffer):null
                                    ):null
                            )
                        );
                    }
                );
            else
                UnityEngine.Debug.LogError(string.Concat("Mail is null or empty.\nGame Object:\t",gameObject.name));
        }
    }
}

// Murat Sancak