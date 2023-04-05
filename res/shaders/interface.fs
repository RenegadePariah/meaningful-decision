#version 400 core

in vec2 tex_coord;

uniform sampler2D tex;
uniform vec3 color;
uniform float fog;

out vec4 out_color;

void main(void){

    out_color=mix(texture(tex,tex_coord),vec4(color,1.0),fog);
}