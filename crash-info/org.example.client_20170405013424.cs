S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 28824
Date: 2017-04-05 01:34:24+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 28824, uid 5000)

Register Information
r0   = 0x000000db, r1   = 0x3f800000
r2   = 0x3f800000, r3   = 0x000000db
r4   = 0xb3fc1a3c, r5   = 0xbef6f484
r6   = 0x00000001, r7   = 0xbef6f038
r8   = 0xbef6f478, r9   = 0xb8605e68
r10  = 0xbef6f498, fp   = 0x00000004
ip   = 0xb5fd2120, sp   = 0xbef6f018
lr   = 0xb27e32e9, pc   = 0xb27e4802
cpsr = 0x400f0030

Memory Information
MemTotal:   987012 KB
MemFree:     56184 KB
Buffers:     53544 KB
Cached:     280084 KB
VmPeak:     103012 KB
VmSize:     103008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22344 KB
VmRSS:       22344 KB
VmData:      31364 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 28824 TID = 28824
28824 28825 29113 29114 

Maps Information
b106b000 b107c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b108c000 b1091000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b138f000 b1397000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13a9000 b1ba8000 rw-p [stack:29114]
b1ba8000 b1ba9000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bb9000 b1bcd000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be1000 b1be2000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf2000 b1bf5000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c06000 b1c07000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c17000 b1c19000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c29000 b1c2b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c3b000 b1c4b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c5b000 b1c67000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c79000 b2478000 rw-p [stack:29113]
b27a9000 b27b0000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c3000 b27c9000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27d9000 b27ed000 r-xp /opt/usr/apps/org.example.client/bin/client
b2946000 b2a29000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a60000 b2a88000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a9a000 b3299000 rw-p [stack:28825]
b3299000 b329b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32ab000 b32b5000 r-xp /lib/libnss_files-2.20-2014.11.so
b32c6000 b32cf000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32e0000 b32f1000 r-xp /lib/libnsl-2.20-2014.11.so
b3304000 b330a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b331b000 b331c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3344000 b334b000 r-xp /usr/lib/libminizip.so.1.0.0
b335b000 b3360000 r-xp /usr/lib/libstorage.so.0.1
b3370000 b33cf000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33e5000 b33f9000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3409000 b344d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b345d000 b3465000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3475000 b34a5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34b8000 b3571000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3585000 b35d8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35e9000 b3604000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3614000 b36d5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36e8000 b36f8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3708000 b3715000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3726000 b372d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b373d000 b377e000 r-xp /usr/lib/libmdm.so.1.2.12
b378e000 b3796000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37a5000 b37b5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37d6000 b3836000 r-xp /usr/lib/libasound.so.2.0.0
b3848000 b384b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b385b000 b385e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b386e000 b3873000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3883000 b3884000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3894000 b389f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38b3000 b38ba000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38ca000 b38d0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38e0000 b38e5000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38f5000 b3910000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3920000 b3927000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3937000 b393a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b394b000 b3979000 r-xp /usr/lib/libidn.so.11.5.44
b3989000 b399f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39b0000 b39ba000 r-xp /usr/lib/libcares.so.2.1.0
b39ca000 b39d4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39e4000 b39e6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39f6000 b39f7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a07000 b3a0b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a1c000 b3a44000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a55000 b3a7e000 r-xp /usr/lib/libturbojpeg.so
b3a9e000 b3aa4000 r-xp /usr/lib/libgif.so.4.1.6
b3ab4000 b3afa000 r-xp /usr/lib/libcurl.so.4.3.0
b3b0b000 b3b2c000 r-xp /usr/lib/libexif.so.12.3.3
b3b47000 b3b5c000 r-xp /usr/lib/libtts.so
b3b6d000 b3b75000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b85000 b3c4b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c6b000 b3d63000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d82000 b3e50000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e67000 b3e69000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e79000 b3e7f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e8f000 b3eb2000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ec3000 b3ec5000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ed5000 b3ed7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ee8000 b3eed000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f04000 b3f06000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f16000 b3f1d000 r-xp /usr/lib/libsensord-share.so
b3f2d000 b3f45000 r-xp /usr/lib/libsensor.so.1.1.0
b3f56000 b3f59000 r-xp /usr/lib/libXv.so.1.0.0
b3f69000 b3f6e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f7e000 b3f83000 r-xp /usr/lib/libappcore-common.so.1.1
b3f93000 b3f9a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fad000 b3fb1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fc2000 b40a0000 r-xp /usr/lib/libCOREGL.so.4.0
b40c0000 b40c3000 r-xp /usr/lib/libuuid.so.1.3.0
b40d3000 b40ea000 r-xp /usr/lib/libblkid.so.1.1.0
b40fb000 b40fd000 r-xp /usr/lib/libXau.so.6.0.0
b410d000 b4154000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4166000 b416c000 r-xp /usr/lib/libjson-c.so.2.0.1
b417d000 b4181000 r-xp /usr/lib/libogg.so.0.7.1
b4191000 b41b3000 r-xp /usr/lib/libvorbis.so.0.4.3
b41c3000 b42a7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42c3000 b42c6000 r-xp /usr/lib/libEGL.so.1.4
b42d7000 b42dd000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ed000 b42ef000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42ff000 b430c000 r-xp /usr/lib/libGLESv2.so.2.0
b431d000 b437f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4394000 b43ac000 r-xp /usr/lib/libmount.so.1.1.0
b43be000 b43d2000 r-xp /usr/lib/libxcb.so.1.1.0
b43e2000 b43e9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4421000 b4423000 r-xp /usr/lib/libiri.so
b4433000 b443e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b444f000 b4485000 r-xp /usr/lib/libpulse.so.0.16.2
b4496000 b44d9000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ee000 b4503000 r-xp /lib/libexpat.so.1.5.2
b4515000 b45d3000 r-xp /usr/lib/libcairo.so.2.11200.14
b45e7000 b45ef000 r-xp /usr/lib/libdrm.so.2.4.0
b45ff000 b4602000 r-xp /usr/lib/libdri2.so.0.0.0
b4612000 b4660000 r-xp /usr/lib/libssl.so.1.0.0
b4675000 b4681000 r-xp /usr/lib/libeeze.so.1.13.0
b4692000 b469b000 r-xp /usr/lib/libethumb.so.1.13.0
b46ab000 b46ae000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46be000 b4875000 r-xp /usr/lib/libcrypto.so.1.0.0
b5660000 b5669000 r-xp /usr/lib/libXi.so.6.1.0
b5679000 b567b000 r-xp /usr/lib/libXgesture.so.7.0.0
b568b000 b568f000 r-xp /usr/lib/libXtst.so.6.1.0
b569f000 b56a5000 r-xp /usr/lib/libXrender.so.1.3.0
b56b5000 b56bb000 r-xp /usr/lib/libXrandr.so.2.2.0
b56cb000 b56cd000 r-xp /usr/lib/libXinerama.so.1.0.0
b56de000 b56e1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56f1000 b56fc000 r-xp /usr/lib/libXext.so.6.4.0
b570c000 b570e000 r-xp /usr/lib/libXdamage.so.1.1.0
b571e000 b5720000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5730000 b5812000 r-xp /usr/lib/libX11.so.6.3.0
b5826000 b582d000 r-xp /usr/lib/libXcursor.so.1.0.2
b583d000 b5855000 r-xp /usr/lib/libudev.so.1.6.0
b5857000 b585a000 r-xp /lib/libattr.so.1.1.0
b586a000 b588a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b588b000 b5890000 r-xp /usr/lib/libffi.so.6.0.2
b58a1000 b58b9000 r-xp /lib/libz.so.1.2.8
b58c9000 b58cb000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58db000 b59b0000 r-xp /usr/lib/libxml2.so.2.9.2
b59c5000 b5a60000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a7c000 b5a7f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a8f000 b5aa8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab9000 b5aca000 r-xp /lib/libresolv-2.20-2014.11.so
b5ade000 b5b58000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b6d000 b5b6f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b7f000 b5b86000 r-xp /usr/lib/libembryo.so.1.13.0
b5b96000 b5ba0000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bb1000 b5bc9000 r-xp /usr/lib/libpng12.so.0.50.0
b5bda000 b5bfd000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c1e000 b5c32000 r-xp /usr/lib/libector.so.1.13.0
b5c43000 b5c5b000 r-xp /usr/lib/liblua-5.1.so
b5c6c000 b5cc3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cd7000 b5cff000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d10000 b5d23000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d34000 b5d6e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d7f000 b5d8d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d9d000 b5da5000 r-xp /usr/lib/libtbm.so.1.0.0
b5db5000 b5dc2000 r-xp /usr/lib/libeio.so.1.13.0
b5dd2000 b5dd4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de4000 b5de9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df9000 b5e10000 r-xp /usr/lib/libefreet.so.1.13.0
b5e22000 b5e42000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e52000 b5e72000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e74000 b5e7a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e8a000 b5e9b000 r-xp /usr/lib/libemotion.so.1.13.0
b5eac000 b5eb3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec3000 b5ed2000 r-xp /usr/lib/libeo.so.1.13.0
b5ee3000 b5ef5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f06000 b5f0b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f1b000 b5f34000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f44000 b5f61000 r-xp /usr/lib/libeet.so.1.13.0
b5f7a000 b5fc2000 r-xp /usr/lib/libeina.so.1.13.0
b5fd3000 b5fe3000 r-xp /usr/lib/libefl.so.1.13.0
b5ff4000 b60d9000 r-xp /usr/lib/libicuuc.so.51.1
b60f6000 b6236000 r-xp /usr/lib/libicui18n.so.51.1
b624d000 b6285000 r-xp /usr/lib/libecore_x.so.1.13.0
b6297000 b629a000 r-xp /lib/libcap.so.2.21
b62aa000 b62d3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e4000 b62eb000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62fd000 b6334000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6345000 b6430000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6443000 b64bc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ce000 b64d3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e3000 b64ed000 r-xp /usr/lib/libvconf.so.0.2.45
b64fd000 b64ff000 r-xp /usr/lib/libvasum.so.0.3.1
b650f000 b6511000 r-xp /usr/lib/libttrace.so.1.1
b6521000 b6524000 r-xp /usr/lib/libiniparser.so.0
b6534000 b655a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b656a000 b656f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6580000 b6597000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a8000 b6613000 r-xp /lib/libm-2.20-2014.11.so
b6624000 b662a000 r-xp /lib/librt-2.20-2014.11.so
b663b000 b6648000 r-xp /usr/lib/libunwind.so.8.0.1
b667e000 b67a2000 r-xp /lib/libc-2.20-2014.11.so
b67b7000 b67d0000 r-xp /lib/libgcc_s-4.9.so.1
b67e0000 b68c2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d3000 b68fd000 r-xp /usr/lib/libdbus-1.so.3.8.12
b690e000 b694a000 r-xp /usr/lib/libsystemd.so.0.4.0
b694c000 b69cf000 r-xp /usr/lib/libedje.so.1.13.0
b69e2000 b6a00000 r-xp /usr/lib/libecore.so.1.13.0
b6a20000 b6ba7000 r-xp /usr/lib/libevas.so.1.13.0
b6bdc000 b6bf0000 r-xp /lib/libpthread-2.20-2014.11.so
b6c04000 b6e38000 r-xp /usr/lib/libelementary.so.1.13.0
b6e67000 b6e6b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e7b000 b6e82000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e92000 b6e94000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea4000 b6ea7000 r-xp /usr/lib/libbundle.so.0.1.22
b6eb7000 b6eb9000 r-xp /lib/libdl-2.20-2014.11.so
b6eca000 b6ee2000 r-xp /usr/lib/libaul.so.0.1.0
b6ef6000 b6efb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f0c000 b6f19000 r-xp /usr/lib/liblptcp.so
b6f2b000 b6f2f000 r-xp /usr/lib/libsys-assert.so
b6f40000 b6f60000 r-xp /lib/ld-2.20-2014.11.so
b6f71000 b6f76000 r-xp /usr/bin/launchpad-loader
b85a2000 b88e0000 rw-p [heap]
bef4f000 bef70000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28824)
Call Stack Count: 15
 0: _ZN7RootObj13setWeightHintEff + 0x17 (0xb27e4802) [/opt/usr/apps/org.example.client/bin/client] + 0xb802
 1: _ZN10MyFoodView6drawUIEP9Naviframe + 0x2ac (0xb27e32e9) [/opt/usr/apps/org.example.client/bin/client] + 0xa2e9
 2: _ZN10MyFoodViewC2EP9Naviframe + 0x58 (0xb27dec1d) [/opt/usr/apps/org.example.client/bin/client] + 0x5c1d
 3: _ZN7MyLoginC2EP9Naviframe + 0xce (0xb27dd523) [/opt/usr/apps/org.example.client/bin/client] + 0x4523
 4: _ZN8MyWindow8onCreateEv + 0x110 (0xb27dd2ad) [/opt/usr/apps/org.example.client/bin/client] + 0x42ad
 5: _ZN6Window10app_createEPv + 0x72 (0xb27e4a8b) [/opt/usr/apps/org.example.client/bin/client] + 0xba8b
 6: _ZN6Window17static_app_createEPv + 0x24 (0xb27e4c01) [/opt/usr/apps/org.example.client/bin/client] + 0xbc01
 7: (0xb3faf4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 8: appcore_efl_main + 0x152 (0xb6ef9203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 9: ui_app_main + 0xc0 (0xb3faf909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27e4f8b) [/opt/usr/apps/org.example.client/bin/client] + 0xbf8b
11: main + 0x40 (0xb27dd035) [/opt/usr/apps/org.example.client/bin/client] + 0x4035
12: (0xb6f72bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
13: __libc_start_main + 0x114 (0xb66944bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f72eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:16.127+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.525+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:32:54.535+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:32:54.535+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:33:00.641+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-05 01:33:00.641+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:33
04-05 01:33:00.641+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 1:33"
04-05 01:33:00.641+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:33"
04-05 01:33:00.641+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-05 01:33:00.641+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147004016 Time: <font_size=31> </font_size> <font_size=31> 오전 1:33</font_size></font>"
04-05 01:34:00.649+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-05 01:34:00.659+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:34
04-05 01:34:00.659+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 1:34"
04-05 01:34:00.659+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:34"
04-05 01:34:00.659+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-05 01:34:00.659+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146903139 Time: <font_size=31> </font_size> <font_size=31> 오전 1:34</font_size></font>"
04-05 01:34:10.259+0900 E/PKGMGR_SERVER(28899): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:10.309+0900 E/PKGMGR  (28897): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 28558
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(2245)
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.349+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(2245) is dead. cmd(5) is canceled
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(2531)
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.349+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(2531) is dead. cmd(5) is canceled
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(2815)
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.349+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(2815) is dead. cmd(5) is canceled
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3136)
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.349+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3136) is dead. cmd(5) is canceled
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.349+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.349+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3407)
04-05 01:34:10.349+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3407) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3679)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3679) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(3974)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(3974) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4251)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4251) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4524)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4524) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(4794)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(4794) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5107)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5107) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5381)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5381) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5733)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5733) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(5856)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(5856) is dead. cmd(5) is canceled
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.359+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.359+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6127)
04-05 01:34:10.359+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.359+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(6127) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6417)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(6417) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(6686)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(6686) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(18306)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(18306) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(18430)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(18430) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(18553)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(18553) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(26716)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 E/AUL_AMD (  610): amd_request.c: __app_process_by_pid(272) > pid(26716) is dead. cmd(5) is canceled
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(-3)
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): pkgmgr-server.c: __terminate_app(1401) > [0;31m[__terminate_app(): 1401](ret < 0) aul_terminate_pid[-3] fail
04-05 01:34:10.369+0900 E/PKGMGR_SERVER(28902): [0;m
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(396) > request cmd(5) to(28558)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 5
04-05 01:34:10.369+0900 I/APP_CORE(28558): appcore-efl.c: __do_app(514) > [APP 28558] Event: TERMINATE State: RUNNING
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(28558), cmd(4)
04-05 01:34:10.369+0900 W/AUL     (28902): launch.c: app_request_to_launchpad(425) > request cmd(5) result(0)
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 28558
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:34:10.369+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:34:10.389+0900 I/TIZEN_N_EFL_UTIL_WINDOW(28558): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 11
04-05 01:34:10.389+0900 E/APP_CORE(28558): appcore-efl.c: _capture_and_make_file(1619) > win[5800002] widget[720] height[1280]
04-05 01:34:10.389+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-05 01:34:10.389+0900 E/APP_CORE(28558): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [org.example.client]
04-05 01:34:10.389+0900 I/CAPI_APPFW_APPLICATION(28558): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-05 01:34:10.389+0900 I/CAPI_APPFW_APPLICATION(28558): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-05 01:34:10.389+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:10.399+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-05 01:34:10.399+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:34:10.399+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-05 01:34:10.399+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-05 01:34:10.399+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-05 01:34:10.409+0900 E/EFL     (28558): eo<28558> lib/eo/eo.c:676 _eo_call_resolve() in elm_win.eo.c:384: func 'elm_obj_win_xwindow_get' (421) could not be resolved for class 'Elm_Naviframe'.
04-05 01:34:10.409+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
04-05 01:34:10.419+0900 I/SWIFTKEY(  695): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
04-05 01:34:10.449+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-05 01:34:10.479+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:34:10.479+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-05 01:34:10.479+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-05 01:34:10.479+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-05 01:34:10.479+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-05 01:34:10.479+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:10.499+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-05 01:34:10.509+0900 E/PKGMGR_SERVER(28899): pkgmgr-server.c: sighandler(417) > child NORMAL exit [28902]
04-05 01:34:10.519+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-05 01:34:10.519+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:10.529+0900 I/ISE_MULTI(  851): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
04-05 01:34:10.539+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-05 01:34:10.549+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:34:10.559+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-05 01:34:10.559+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:34:10.559+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-05 01:34:10.559+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-05 01:34:10.559+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:34:10.559+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:34:10.579+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b784c0]
04-05 01:34:10.579+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-05 01:34:10.579+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b784c0
04-05 01:34:10.589+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-05 01:34:10.589+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-05 01:34:10.589+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-05 01:34:10.589+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-05 01:34:10.589+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-05 01:34:10.809+0900 E/VCONF   (28558): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-05 01:34:10.809+0900 E/VCONF   (28558): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-05 01:34:10.839+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 28558 pgid = 28558
04-05 01:34:10.839+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(28558)
04-05 01:34:10.869+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-05 01:34:10.869+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-05 01:34:10.869+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-05 01:34:10.879+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 28558
04-05 01:34:10.879+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[28558] terminate event is forwarded
04-05 01:34:10.879+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-05 01:34:10.879+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 28558, ]
04-05 01:34:10.879+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-05 01:34:10.879+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-05 01:34:10.879+0900 I/Tizen::App( 1231): (512) > Not registered pid(28558)
04-05 01:34:10.879+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-05 01:34:10.879+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:10.879+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 28558
04-05 01:34:10.879+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1573
04-05 01:34:10.889+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:34:10.889+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 28558.
04-05 01:34:11.450+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
04-05 01:34:12.641+0900 E/PKGMGR_SERVER(28899): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:12.641+0900 E/PKGMGR_SERVER(28899): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:14.193+0900 E/PKGMGR  (28993): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-05 01:34:14.283+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:14.323+0900 E/PKGMGR_SERVER(28995): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-05 01:34:14.333+0900 E/PKGMGR_SERVER(28995): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-05 01:34:14.333+0900 E/PKGMGR  (28993): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[289930002]
04-05 01:34:14.473+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.473+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-05 01:34:14.473+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.473+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [96]
04-05 01:34:14.483+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-05 01:34:14.483+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.483+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.483+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:34:14.483+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:34:14.483+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:34:14.623+0900 W/CERT_SVC_VCORE(28998): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:34:14.693+0900 E/rpm-installer(28998): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-05 01:34:14.693+0900 E/rpm-installer(28998): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-05 01:34:14.743+0900 E/PKGMGR_PARSER(28998): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-CLIENT(28998): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-CLIENT(28998): SocketClient.cpp: connect(62) > Client connected
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-SERVER(  915): SocketService.cpp: mainloop(230) > Got incoming connection
04-05 01:34:14.763+0900 I/PRIVACY-MANAGER-CLIENT(28998): SocketClient.cpp: disconnect(72) > Client disconnected
04-05 01:34:14.773+0900 E/PKGMGR_CERT(28998): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-05 01:34:14.773+0900 E/PKGMGR_CERT(28998): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-05 01:34:14.783+0900 E/PKGMGR_CERT(28998): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-05 01:34:14.813+0900 E/rpm-installer(28998): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-05 01:34:14.813+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-05 01:34:14.813+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-05 01:34:14.813+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.813+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:14.813+0900 E/ESD     (  893): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-05 01:34:14.823+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-05 01:34:14.823+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-05 01:34:14.823+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-05 01:34:15.364+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:34:15.364+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:34:16.475+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: sighandler(417) > child NORMAL exit [28998]
04-05 01:34:16.635+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:16.635+0900 E/PKGMGR_SERVER(28995): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:17.346+0900 E/PKGMGR  (29046): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-05 01:34:17.426+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:34:17.476+0900 E/PKGMGR_SERVER(29048): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-05 01:34:17.486+0900 E/PKGMGR_INFO(29048): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-05 01:34:17.486+0900 E/rpm-installer(29048): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-05 01:34:17.496+0900 E/PKGMGR_SERVER(29048): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-05 01:34:17.496+0900 E/PKGMGR  (29046): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[290460002]
04-05 01:34:17.626+0900 E/PKGMGR_INSTALLER(29051): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-05 01:34:17.626+0900 E/rpm-installer(29051): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:17.646+0900 E/rpm-installer(29051): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-05 01:34:17.646+0900 E/rpm-installer(29051): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:34:17.716+0900 W/CERT_SVC_VCORE(29051): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-05 01:34:17.766+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-05 01:34:17.766+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-05 01:34:17.766+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.766+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.776+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-05 01:34:17.776+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [30]
04-05 01:34:17.776+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-05 01:34:17.776+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.776+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:17.966+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:17.966+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-05 01:34:17.976+0900 E/rpm-installer(29051): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-05 01:34:17.976+0900 E/PKGMGR_PARSER(29051): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-05 01:34:17.986+0900 E/PKGMGR_PARSER(29051): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-05 01:34:18.016+0900 I/PRIVACY-MANAGER-CLIENT(29051): SocketClient.cpp: SocketClient(37) > Client created
04-05 01:34:18.226+0900 E/PKGMGR_PARSER(29051): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-05 01:34:18.246+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-05 01:34:18.256+0900 E/PKGMGR_CERT(29051): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-05 01:34:18.266+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.266+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.266+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-05 01:34:18.266+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [60]
04-05 01:34:18.266+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-05 01:34:18.276+0900 E/rpm-installer(29051): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-05 01:34:18.297+0900 E/rpm-installer(29051): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-05 01:34:18.307+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.307+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-05 01:34:18.307+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:18.307+0900 I/Tizen::App( 1231): (119) > InstallationInProgress [100]
04-05 01:34:18.307+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-05 01:34:19.638+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-05 01:34:20.288+0900 I/Tizen::App( 1231): (1894) > PackageEventHandler - req: 12310002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-05 01:34:20.288+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-05 01:34:20.288+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-05 01:34:20.288+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-05 01:34:20.288+0900 I/Tizen::App( 1231): (78) > Installation is Completed. [Package = org.example.client]
04-05 01:34:20.288+0900 I/Tizen::App( 1231): (671) > Enter. package(org.example.client), installationResult(0)
04-05 01:34:20.288+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:20.288+0900 E/PKGMGR  ( 1639): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-05 01:34:20.308+0900 I/Tizen::App( 1231): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-05 01:34:20.318+0900 I/Tizen::App( 1231): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-05 01:34:20.329+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-05 01:34:20.329+0900 W/ISF_PANEL_EFL(  788): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-05 01:34:20.349+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:34:20.349+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:34:20.359+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29051]
04-05 01:34:20.359+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-05 01:34:20.359+0900 E/HOME_APPS(  858): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-05 01:34:20.359+0900 E/cluster-home(  858): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-05 01:34:20.359+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-05 01:34:20.359+0900 E/PKGMGR_INFO( 1231): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (683) > Application count(1) in this package
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (703) > Exit.
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-05 01:34:20.359+0900 I/Tizen::App( 1231): (840) > Enter.
04-05 01:34:20.379+0900 E/util-view(  858): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (416) > appName = [client]
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-05 01:34:20.379+0900 I/Tizen::App( 1231): (131) > Enter
04-05 01:34:20.389+0900 I/Tizen::App( 1231): (137) > org.example.client does not have launch condition
04-05 01:34:20.389+0900 I/Tizen::App( 1231): (883) > Exit.
04-05 01:34:20.389+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-05 01:34:21.640+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:34:21.640+0900 E/PKGMGR_SERVER(29048): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:34:24.443+0900 W/AUL     (29106): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-05 01:34:24.443+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-05 01:34:24.453+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-05 01:34:24.463+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-05 01:34:24.463+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-05 01:34:24.463+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 29106
04-05 01:34:24.463+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-05 01:34:24.473+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-05 01:34:24.473+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-05 01:34:24.473+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-05 01:34:24.483+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-05 01:34:24.483+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-05 01:34:24.493+0900 I/abc     (28824): abc
04-05 01:34:24.493+0900 I/CAPI_APPFW_APPLICATION(28824): app_main.c: ui_app_main(789) > app_efl_main
04-05 01:34:24.493+0900 I/CAPI_APPFW_APPLICATION(28824): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-05 01:34:24.523+0900 E/TBM     (28824): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:34:24.583+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 28824, appid: org.example.client
04-05 01:34:24.583+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-05 01:34:24.583+0900 W/AUL     (29106): launch.c: app_request_to_launchpad(425) > request cmd(0) result(28824)
04-05 01:34:24.763+0900 D/basicui (28824): successed to load edc file
04-05 01:34:24.793+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:24.793+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:24.813+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-05 01:34:24.813+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:24.823+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:34:24.823+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:34:25.123+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:25.153+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:34:25.153+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:34:25.173+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-05 01:34:25.173+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:34:25.173+0900 W/CRASH_MANAGER(29122): worker.c: worker_job(1199) > 1128824636c69149132366
