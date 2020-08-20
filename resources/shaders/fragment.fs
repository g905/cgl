#version 330 core
out vec4 fragColor;

in vec3 ourColor;
in vec2 texCoord;

uniform sampler2D texture_sampler1;
uniform sampler2D texture_sampler2;
uniform float opacity;

void main() {

    fragColor = mix(texture(texture_sampler1, texCoord), texture(texture_sampler2, vec2(1.0 - texCoord.x, texCoord.y)), opacity);
}