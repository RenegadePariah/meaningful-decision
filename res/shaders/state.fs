#version 400 core

in vec2 pass_c1;
in vec2 pass_c2;

uniform vec3 color;
uniform sampler2D tex1;
uniform sampler2D tex2;

uniform float contrast;
uniform float brightness;
uniform float color_blend_factor;
uniform float alpha_blend_factor;
uniform float alpha_mod;

out vec4 out_color;

void main(void){
    vec2 v1=texture(tex1,pass_c1).xw;
    vec2 v2=texture(tex2,pass_c2).xw;
    float lum1=((v1.x-0.6)*10.0)+0.5;
    float lum2=v2.x;
    out_color=vec4(color*mix(lum1,lum2,color_blend_factor),1.0);
    if(mix(v1.y,v2.y,alpha_blend_factor)+alpha_mod<0.5)discard;
}