Shader "Unlit/WaterShader"   //name of the shader as it appears in unity. 
//in the inspector you can go to shaders adn select it. You can Change "Unlit" to whatever you want and thats how it'll look in unity. 
{
    Properties  // the public variables that get exposed to the material. 
    {
        _MainTex ("Texture", 2D) = "white" {}   //white is the default color you're setting. 
        _WaveHeight("Wave Height", float) = 0.5
        _WaveFrequency("Wave Frequency", float) = 2.0
        
    }
    
    //where we actually start writing code. 
    SubShader
    {
    
        // UNITY Specific stuff to help unity optimize this shader. 
        Tags { "RenderType"="Opaque" }
        //LOD = level of detail... higher numbers tell unity this is a more $$$ shader. 
        LOD 100
        
        
        //"Pass" is like an update loops for your shader
        //fewer is better and more optimized ("Single-pass" vs multi-pass)
        Pass
        {
           
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc" 

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };


        
            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            
            //you must declare "twins" that correspond to your properties. 
            float _WaveHeight;
            float _WaveFrequency;
            
            

            //vertex program 
            v2f vert (appdata v)
            {
                v2f o;
                // add sine wave to vertex position to make it bumpy.
                //float4 means a vect 4 (4th number is a special thing unity uses) 
                v.vertex += float4( 0, sin((_Time.z + v.vertex.x) * _WaveFrequency ) * _WaveHeight, 0, 0 ); 
                //v.vertex += float4( 0, sin(_Time.z + v.vertex.x), 0, 0 ); //0x, sine for y, 0z, 0w //_Time.x is like time.time 
                // _Time.z is a ...faster... version of time?
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                //fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 col = tex2D(_MainTex, i.uv + float2(_Time.x * .2f, _Time.x * .2f));
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}


/* SHADERS:

when you want to adjust the shape of something use the vertex shader. 
"Fragment" shader takes vertex data and turns into a pixel through Rasterization.
fragment ~ pixel. blur bloom and post processing is fragment b/c its pixels  

1. New Folder: Shader
Create > NewShader > unlit Shader

shaders use the GPU not CPU 
unity doesnt know what is happening. 
unity shader graph 

*/ 