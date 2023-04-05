#version 400 core

in vec2 pass_pos;

uniform vec3 color;

out vec4 out_color;

void main(void){
    float dist=pow(pass_pos.x*pass_pos.x+pass_pos.y*pass_pos.y,0.5);
    out_color=vec4(color*(1.0-dist*1.5),1.0);
}