S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 16055
Date: 2017-06-13 14:02:03+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb27c265a

Register Information
r0   = 0xb75ffde8, r1   = 0xb75fbd20
r2   = 0xb75fbd20, r3   = 0xb75ffde8
r4   = 0xb3fb1a3c, r5   = 0xbebbf484
r6   = 0x00000001, r7   = 0xbebbf348
r8   = 0xbebbf478, r9   = 0xb744da40
r10  = 0xbebbf498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbebbf2ec
lr   = 0xb27c25d7, pc   = 0xb27c265a
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     70352 KB
Buffers:     61928 KB
Cached:     228084 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19572 KB
VmRSS:       19572 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16055 TID = 16055
16055 16059 16073 16074 

Maps Information
b1373000 b137b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b138d000 b1b8c000 rw-p [stack:16074]
b1b8c000 b1b8d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b9d000 b1bb1000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bc5000 b1bc6000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bd6000 b1bd9000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bea000 b1beb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bfb000 b1bfd000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c0d000 b1c0f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c1f000 b1c2f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c3f000 b1c4b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c5d000 b245c000 rw-p [stack:16073]
b278d000 b2794000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27a7000 b27ad000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27bd000 b27ed000 r-xp /opt/usr/apps/org.example.client/bin/client
b2936000 b2a19000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a50000 b2a78000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a8a000 b3289000 rw-p [stack:16059]
b3289000 b328b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b329b000 b32a5000 r-xp /lib/libnss_files-2.20-2014.11.so
b32b6000 b32bf000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32d0000 b32e1000 r-xp /lib/libnsl-2.20-2014.11.so
b32f4000 b32fa000 r-xp /lib/libnss_compat-2.20-2014.11.so
b330b000 b330c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3334000 b333b000 r-xp /usr/lib/libminizip.so.1.0.0
b334b000 b3350000 r-xp /usr/lib/libstorage.so.0.1
b3360000 b33bf000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33d5000 b33e9000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33f9000 b343d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b344d000 b3455000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3465000 b3495000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34a8000 b3561000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3575000 b35c8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35d9000 b35f4000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3604000 b36c5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36d8000 b36e8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36f8000 b3705000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3716000 b371d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b372d000 b376e000 r-xp /usr/lib/libmdm.so.1.2.12
b377e000 b3786000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3795000 b37a5000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37c6000 b3826000 r-xp /usr/lib/libasound.so.2.0.0
b3838000 b383b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b384b000 b384e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b385e000 b3863000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3873000 b3874000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3884000 b388f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38a3000 b38aa000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38ba000 b38c0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38d0000 b38d5000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38e5000 b3900000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3910000 b3917000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3927000 b392a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b393b000 b3969000 r-xp /usr/lib/libidn.so.11.5.44
b3979000 b398f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39a0000 b39aa000 r-xp /usr/lib/libcares.so.2.1.0
b39ba000 b39c4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39d4000 b39d6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39e6000 b39e7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39f7000 b39fb000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a0c000 b3a34000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a45000 b3a6e000 r-xp /usr/lib/libturbojpeg.so
b3a8e000 b3a94000 r-xp /usr/lib/libgif.so.4.1.6
b3aa4000 b3aea000 r-xp /usr/lib/libcurl.so.4.3.0
b3afb000 b3b1c000 r-xp /usr/lib/libexif.so.12.3.3
b3b37000 b3b4c000 r-xp /usr/lib/libtts.so
b3b5d000 b3b65000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b75000 b3c3b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c5b000 b3d53000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d72000 b3e40000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e57000 b3e59000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e69000 b3e6f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e7f000 b3ea2000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3eb3000 b3eb5000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ec5000 b3ec7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ed8000 b3edd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ef4000 b3ef6000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f06000 b3f0d000 r-xp /usr/lib/libsensord-share.so
b3f1d000 b3f35000 r-xp /usr/lib/libsensor.so.1.1.0
b3f46000 b3f49000 r-xp /usr/lib/libXv.so.1.0.0
b3f59000 b3f5e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f6e000 b3f73000 r-xp /usr/lib/libappcore-common.so.1.1
b3f83000 b3f8a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f9d000 b3fa1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fb2000 b4090000 r-xp /usr/lib/libCOREGL.so.4.0
b40b0000 b40b3000 r-xp /usr/lib/libuuid.so.1.3.0
b40c3000 b40da000 r-xp /usr/lib/libblkid.so.1.1.0
b40eb000 b40ed000 r-xp /usr/lib/libXau.so.6.0.0
b40fd000 b4144000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4156000 b415c000 r-xp /usr/lib/libjson-c.so.2.0.1
b416d000 b4171000 r-xp /usr/lib/libogg.so.0.7.1
b4181000 b41a3000 r-xp /usr/lib/libvorbis.so.0.4.3
b41b3000 b4297000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42b3000 b42b6000 r-xp /usr/lib/libEGL.so.1.4
b42c7000 b42cd000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42dd000 b42df000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42ef000 b42fc000 r-xp /usr/lib/libGLESv2.so.2.0
b430d000 b436f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4384000 b439c000 r-xp /usr/lib/libmount.so.1.1.0
b43ae000 b43c2000 r-xp /usr/lib/libxcb.so.1.1.0
b43d2000 b43d9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4411000 b4413000 r-xp /usr/lib/libiri.so
b4423000 b442e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b443f000 b4475000 r-xp /usr/lib/libpulse.so.0.16.2
b4486000 b44c9000 r-xp /usr/lib/libsndfile.so.1.0.25
b44de000 b44f3000 r-xp /lib/libexpat.so.1.5.2
b4505000 b45c3000 r-xp /usr/lib/libcairo.so.2.11200.14
b45d7000 b45df000 r-xp /usr/lib/libdrm.so.2.4.0
b45ef000 b45f2000 r-xp /usr/lib/libdri2.so.0.0.0
b4602000 b4650000 r-xp /usr/lib/libssl.so.1.0.0
b4665000 b4671000 r-xp /usr/lib/libeeze.so.1.13.0
b4682000 b468b000 r-xp /usr/lib/libethumb.so.1.13.0
b469b000 b469e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46ae000 b4865000 r-xp /usr/lib/libcrypto.so.1.0.0
b5650000 b5659000 r-xp /usr/lib/libXi.so.6.1.0
b5669000 b566b000 r-xp /usr/lib/libXgesture.so.7.0.0
b567b000 b567f000 r-xp /usr/lib/libXtst.so.6.1.0
b568f000 b5695000 r-xp /usr/lib/libXrender.so.1.3.0
b56a5000 b56ab000 r-xp /usr/lib/libXrandr.so.2.2.0
b56bb000 b56bd000 r-xp /usr/lib/libXinerama.so.1.0.0
b56ce000 b56d1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56e1000 b56ec000 r-xp /usr/lib/libXext.so.6.4.0
b56fc000 b56fe000 r-xp /usr/lib/libXdamage.so.1.1.0
b570e000 b5710000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5720000 b5802000 r-xp /usr/lib/libX11.so.6.3.0
b5816000 b581d000 r-xp /usr/lib/libXcursor.so.1.0.2
b582d000 b5845000 r-xp /usr/lib/libudev.so.1.6.0
b5847000 b584a000 r-xp /lib/libattr.so.1.1.0
b585a000 b587a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b587b000 b5880000 r-xp /usr/lib/libffi.so.6.0.2
b5891000 b58a9000 r-xp /lib/libz.so.1.2.8
b58b9000 b58bb000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58cb000 b59a0000 r-xp /usr/lib/libxml2.so.2.9.2
b59b5000 b5a50000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a6c000 b5a6f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a7f000 b5a98000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aa9000 b5aba000 r-xp /lib/libresolv-2.20-2014.11.so
b5ace000 b5b48000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b5d000 b5b5f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b6f000 b5b76000 r-xp /usr/lib/libembryo.so.1.13.0
b5b86000 b5b90000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5ba1000 b5bb9000 r-xp /usr/lib/libpng12.so.0.50.0
b5bca000 b5bed000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c0e000 b5c22000 r-xp /usr/lib/libector.so.1.13.0
b5c33000 b5c4b000 r-xp /usr/lib/liblua-5.1.so
b5c5c000 b5cb3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cc7000 b5cef000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d00000 b5d13000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d24000 b5d5e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d6f000 b5d7d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d8d000 b5d95000 r-xp /usr/lib/libtbm.so.1.0.0
b5da5000 b5db2000 r-xp /usr/lib/libeio.so.1.13.0
b5dc2000 b5dc4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dd4000 b5dd9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5de9000 b5e00000 r-xp /usr/lib/libefreet.so.1.13.0
b5e12000 b5e32000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e42000 b5e62000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e64000 b5e6a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e7a000 b5e8b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e9c000 b5ea3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5eb3000 b5ec2000 r-xp /usr/lib/libeo.so.1.13.0
b5ed3000 b5ee5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ef6000 b5efb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f0b000 b5f24000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f34000 b5f51000 r-xp /usr/lib/libeet.so.1.13.0
b5f6a000 b5fb2000 r-xp /usr/lib/libeina.so.1.13.0
b5fc3000 b5fd3000 r-xp /usr/lib/libefl.so.1.13.0
b5fe4000 b60c9000 r-xp /usr/lib/libicuuc.so.51.1
b60e6000 b6226000 r-xp /usr/lib/libicui18n.so.51.1
b623d000 b6275000 r-xp /usr/lib/libecore_x.so.1.13.0
b6287000 b628a000 r-xp /lib/libcap.so.2.21
b629a000 b62c3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62d4000 b62db000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62ed000 b6324000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6335000 b6420000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6433000 b64ac000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64be000 b64c3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64d3000 b64dd000 r-xp /usr/lib/libvconf.so.0.2.45
b64ed000 b64ef000 r-xp /usr/lib/libvasum.so.0.3.1
b64ff000 b6501000 r-xp /usr/lib/libttrace.so.1.1
b6511000 b6514000 r-xp /usr/lib/libiniparser.so.0
b6524000 b654a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b655a000 b655f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6570000 b6587000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6598000 b6603000 r-xp /lib/libm-2.20-2014.11.so
b6614000 b661a000 r-xp /lib/librt-2.20-2014.11.so
b662b000 b6638000 r-xp /usr/lib/libunwind.so.8.0.1
b666e000 b6792000 r-xp /lib/libc-2.20-2014.11.so
b67a7000 b67c0000 r-xp /lib/libgcc_s-4.9.so.1
b67d0000 b68b2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68c3000 b68ed000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68fe000 b693a000 r-xp /usr/lib/libsystemd.so.0.4.0
b693c000 b69bf000 r-xp /usr/lib/libedje.so.1.13.0
b69d2000 b69f0000 r-xp /usr/lib/libecore.so.1.13.0
b6a10000 b6b97000 r-xp /usr/lib/libevas.so.1.13.0
b6bcc000 b6be0000 r-xp /lib/libpthread-2.20-2014.11.so
b6bf4000 b6e28000 r-xp /usr/lib/libelementary.so.1.13.0
b6e57000 b6e5b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e6b000 b6e72000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e82000 b6e84000 r-xp /usr/lib/libdlog.so.0.0.0
b6e94000 b6e97000 r-xp /usr/lib/libbundle.so.0.1.22
b6ea7000 b6ea9000 r-xp /lib/libdl-2.20-2014.11.so
b6eba000 b6ed2000 r-xp /usr/lib/libaul.so.0.1.0
b6ee6000 b6eeb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6efc000 b6f09000 r-xp /usr/lib/liblptcp.so
b6f1b000 b6f1f000 r-xp /usr/lib/libsys-assert.so
b6f30000 b6f50000 r-xp /lib/ld-2.20-2014.11.so
b6f61000 b6f66000 r-xp /usr/bin/launchpad-loader
b73e7000 b762c000 rw-p [heap]
beb9f000 bebc0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16055)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb27c265a) [/opt/usr/apps/org.example.client/bin/client] + 0x565a
 1: _ZN7MyLoginC2EP9Naviframe + 0x86 (0xb27c25d7) [/opt/usr/apps/org.example.client/bin/client] + 0x55d7
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb27c23a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb27db5db) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5db
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb27db751) [/opt/usr/apps/org.example.client/bin/client] + 0x1e751
 5: (0xb3f9f4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6ee9203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3f9f909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27dbadb) [/opt/usr/apps/org.example.client/bin/client] + 0x1eadb
 9: main + 0x40 (0xb27c2129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f62bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66844bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f62eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
b(575) >  #Step 2
06-13 14:01:52.076+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 14:01:52.086+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 14:01:52.106+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 14:01:52.106+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:52.106+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 14:01:52.116+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 14:01:52.116+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15947]
06-13 14:01:52.116+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 14:01:52.126+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 14:01:52.126+0900 E/RESOURCED(  667): procfs.c: proc_get_oom_score_adj(131) > fopen /proc/15947/oom_score_adj failed
06-13 14:01:52.126+0900 E/RESOURCED(  667): proc-main.c: resourced_proc_status_change(867) > Empty pid or process not exists. 15947
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:01:52.126+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 14:01:52.126+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 14:01:52.136+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 14:01:52.136+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
06-13 14:01:52.136+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 14:01:52.136+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 14:01:52.136+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 14:01:52.136+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (131) > Enter
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 14:01:52.146+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 14:01:52.156+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 14:01:52.196+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
06-13 14:01:53.788+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 14:01:53.788+0900 E/PKGMGR_SERVER(15944): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 14:01:56.360+0900 W/AUL     (16003): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 14:01:56.360+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:01:56.370+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 14:01:56.370+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 14:01:56.370+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:01:56.370+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 16003
06-13 14:01:56.370+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:01:56.380+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:01:56.380+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:01:56.390+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:01:56.390+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:01:56.390+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:01:56.400+0900 I/abc     (15731): abc
06-13 14:01:56.400+0900 I/CAPI_APPFW_APPLICATION(15731): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:01:56.400+0900 I/CAPI_APPFW_APPLICATION(15731): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:01:56.430+0900 E/TBM     (15731): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:01:56.490+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15731, appid: org.example.client
06-13 14:01:56.490+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:01:56.490+0900 W/AUL     (16003): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15731)
06-13 14:01:56.931+0900 W/CRASH_MANAGER(16018): worker.c: worker_job(1199) > 0415731636c691497330116
06-13 14:01:57.491+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:01:57.491+0900 W/AUL_AMD (  607): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-13 14:01:57.531+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15731 pgid = 15731
06-13 14:01:57.531+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(15731)
06-13 14:01:57.531+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 15731.
06-13 14:01:57.531+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1607
06-13 14:01:57.591+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:01:57.591+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:01:57.591+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:01:57.591+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 15731.
06-13 14:01:57.591+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15731
06-13 14:01:57.591+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15731
06-13 14:01:57.591+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15731
06-13 14:01:57.591+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1608
06-13 14:01:58.432+0900 I/UXT     (16029): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:01:58.843+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17105053
06-13 14:01:58.873+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:01:58.873+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4739) >  Main Scroll Started Done
06-13 14:01:58.893+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:01:58.893+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:01:58.893+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:01:58.893+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:01:58.943+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17105152
06-13 14:01:59.663+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17105870
06-13 14:01:59.724+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17105936
06-13 14:01:59.734+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:01:59.734+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:01:59.734+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:01:59.744+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:01:59.744+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:01:59.744+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:01:59.744+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:01:59.744+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:01:59.754+0900 I/abc     (16029): abc
06-13 14:01:59.754+0900 I/CAPI_APPFW_APPLICATION(16029): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:01:59.764+0900 I/CAPI_APPFW_APPLICATION(16029): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:01:59.784+0900 E/TBM     (16029): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:01:59.844+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16029, appid: org.example.client
06-13 14:01:59.844+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:01:59.844+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16029)
06-13 14:02:00.264+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:02:00.264+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:02
06-13 14:02:00.264+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:02"
06-13 14:02:00.264+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:02"
06-13 14:02:00.264+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:02:00.264+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147039703 Time: <font_size=31> </font_size> <font_size=31> 오후 2:02</font_size></font>"
06-13 14:02:00.875+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16029 pgid = 16029
06-13 14:02:00.875+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16029)
06-13 14:02:00.875+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16029.
06-13 14:02:00.905+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:02:00.905+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:02:00.905+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:02:00.905+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16029.
06-13 14:02:00.915+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16029
06-13 14:02:00.915+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16029
06-13 14:02:00.915+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16029
06-13 14:02:01.725+0900 I/UXT     (16055): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:02:02.486+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17108696
06-13 14:02:02.556+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17108762
06-13 14:02:03.017+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17109222
06-13 14:02:03.077+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17109288
06-13 14:02:03.087+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:02:03.087+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:02:03.087+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:02:03.097+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:02:03.097+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:02:03.097+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:02:03.097+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:02:03.097+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:02:03.117+0900 I/abc     (16055): abc
06-13 14:02:03.117+0900 I/CAPI_APPFW_APPLICATION(16055): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:02:03.117+0900 I/CAPI_APPFW_APPLICATION(16055): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:02:03.147+0900 E/TBM     (16055): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:02:03.197+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16055, appid: org.example.client
06-13 14:02:03.197+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:02:03.207+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16055)
06-13 14:02:03.667+0900 W/CRASH_MANAGER(16018): worker.c: worker_job(1199) > 0416029636c691497330119
06-13 14:02:04.228+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16055 pgid = 16055
06-13 14:02:04.228+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16055)
06-13 14:02:04.228+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16055.
06-13 14:02:04.258+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:02:04.258+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:02:04.258+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:02:04.258+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16055
06-13 14:02:04.258+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16055.
06-13 14:02:04.258+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16055
06-13 14:02:04.258+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16055
06-13 14:02:04.368+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17110497
06-13 14:02:04.368+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:02:04.368+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17110580
06-13 14:02:04.368+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:02:04.368+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollStarted(4737) >  Main Scroll Started
06-13 14:02:04.538+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4747) >  Main Scroll Completed
06-13 14:02:04.538+0900 W/cluster-home( 1167): cluster-data-provider.cpp: OnMainScrollCompleted(4750) >  Main Scroll Completed Done
06-13 14:02:04.578+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17110653
06-13 14:02:04.578+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:02:04.578+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17110792
06-13 14:02:04.578+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:02:04.929+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17111070
06-13 14:02:04.939+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Down]Event!! 
06-13 14:02:04.939+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17111149
06-13 14:02:04.939+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Back]Key [Up]Event!! 
06-13 14:02:05.129+0900 I/UXT     (16099): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:02:05.559+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:05.569+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:02:05.569+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:02:05.569+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:02:05.569+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:02:05.619+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:02:05.629+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:02:05.940+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17112153
06-13 14:02:05.940+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=17112153
06-13 14:02:05.940+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Down]Event!! 
06-13 14:02:05.940+0900 W/STARTER (  721): hw_key.c: _key_press_cb(758) > [_key_press_cb:758] Home Key is pressed
06-13 14:02:05.940+0900 W/STARTER (  721): hw_key.c: _key_press_cb(776) > [_key_press_cb:776] homekey count : 1
06-13 14:02:06.240+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:02:06.240+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:02:06.240+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:02:06.240+0900 E/STARTER (  721): )
06-13 14:02:06.240+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:02:06.240+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:02:06.240+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:02:06.250+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.task-mgr)
06-13 14:02:06.250+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:02:06.260+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/starter, ret : 0
06-13 14:02:06.260+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 14:02:06.260+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 721
06-13 14:02:06.260+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 14:02:06.270+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:02:06.270+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:02:06.270+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:02:06.270+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:02:06.290+0900 I/GXT_SIB (  342): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:02:06.300+0900 E/CAPI_APPFW_APPLICATION(15778): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:02:06.300+0900 E/CAPI_APPFW_APPLICATION(15778): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:02:06.300+0900 E/CAPI_APPFW_APPLICATION(15778): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:02:06.300+0900 E/CAPI_APPFW_APPLICATION(15778): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:02:06.300+0900 E/CAPI_APPFW_APPLICATION(15778): app_error.c: app_error(59) > [ui_app_add_event_handler] INVALID_PARAMETER(0xffffffea) : null parameter
06-13 14:02:06.300+0900 I/CAPI_APPFW_APPLICATION(15778): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:02:06.300+0900 I/CAPI_APPFW_APPLICATION(15778): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:02:06.300+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:783 _eo_api_op_id_get() in elm_layout.eo.c:34: unable to resolve regular api func 'elm_obj_layout_edje_get' 0xb6bdc6e9 in class 'Edje_Object'.
06-13 14:02:06.300+0900 E/UXT     (  342): uxt_theme_object.c: uxt_theme_object_set_changeable_ui_enabled(42) > failed to get edje from parent object.
06-13 14:02:06.380+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15778, appid: com.samsung.task-mgr
06-13 14:02:06.380+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:02:06.380+0900 E/RESOURCED(  667): proc-main.c: proc_add_program_list(237) > not found ppi : com.samsung.task-mgr
06-13 14:02:06.380+0900 W/AUL     (  721): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15778)
06-13 14:02:06.380+0900 W/TASK_MGR_LITE(15778): task-mgr-lite.c: create_win(197) > changeable ui enabled success
06-13 14:02:06.390+0900 I/GXT_SIB (15778): gxt_shared_image_buffer.c: gxt_shared_image_buffer_initialize(113) > [Shared Image Buffer] flink_id=5
06-13 14:02:06.430+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:02:06.430+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:02:06.470+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 12
06-13 14:02:06.470+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:02:06.470+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:02:06.470+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:06.480+0900 E/RUA     (15778): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 24, ncols : 5
06-13 14:02:06.480+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.480+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 14:02:06.490+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.490+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.sdbd-syspopup) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.crash-viewer) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (wifi-efl-ug-lite) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (net.wifi-qs) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.smart-switch-noti) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.setup-wizard) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
06-13 14:02:06.490+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
06-13 14:02:06.500+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.520+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.530+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.550+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.560+0900 I/APP_CORE(15778): appcore-efl.c: __do_app(514) > [APP 15778] Event: RESET State: CREATED
06-13 14:02:06.560+0900 I/CAPI_APPFW_APPLICATION(15778): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-13 14:02:06.560+0900 E/EFL     (15778): edje<15778> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:06.560+0900 E/EFL     (15778): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:06.560+0900 E/EFL     (15778): edje<15778> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:06.560+0900 E/EFL     (15778): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:06.570+0900 W/APP_CORE(15778): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200003
06-13 14:02:06.570+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.570+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
06-13 14:02:06.580+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.600+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.620+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.630+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.650+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.670+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(15778) status(0)
06-13 14:02:06.690+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: PAUSE State: RUNNING
06-13 14:02:06.690+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:02:06.690+0900 E/cluster-home( 1167): homescreen.cpp: OnPause(260) >  app pause
06-13 14:02:06.700+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(15778) status(0)
06-13 14:02:06.700+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(4)
06-13 14:02:06.700+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(1167)
06-13 14:02:06.700+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: bg
06-13 14:02:06.700+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(15778) status(3)
06-13 14:02:06.700+0900 E/EFL     (  342): evas-gl_x11<342> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
06-13 14:02:06.700+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:02:06.700+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:02:06.700+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(15778)
06-13 14:02:06.700+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15778, appid: com.samsung.task-mgr, status: fg
06-13 14:02:06.710+0900 E/weather-widget( 1324): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-13 14:02:06.710+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-13 14:02:06.710+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-13 14:02:06.710+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: bg
06-13 14:02:06.710+0900 I/APP_CORE(15778): appcore-efl.c: __do_app(514) > [APP 15778] Event: RESUME State: CREATED
06-13 14:02:06.720+0900 I/APP_CORE(15778): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-13 14:02:06.720+0900 I/APP_CORE(15778): appcore-efl.c: __do_app(625) > [APP 15778] Initial Launching, call the resume_cb
06-13 14:02:06.720+0900 I/CAPI_APPFW_APPLICATION(15778): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:02:07.071+0900 W/STARTER (  721): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
06-13 14:02:07.071+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17113284
06-13 14:02:07.071+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=17113284
06-13 14:02:07.071+0900 E/cluster-view( 1167): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
06-13 14:02:07.071+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
06-13 14:02:07.071+0900 E/STARTER (  721): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
06-13 14:02:07.071+0900 E/STARTER (  721): )
06-13 14:02:07.071+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
06-13 14:02:07.081+0900 I/SYSPOPUP(  859): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
06-13 14:02:07.081+0900 E/VOLUME  (  859): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-13 14:02:07.081+0900 E/VOLUME  (  859): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-13 14:02:07.301+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17113516
06-13 14:02:07.411+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1620
06-13 14:02:07.411+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17113627
06-13 14:02:07.411+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.task-mgr)
06-13 14:02:07.411+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.task-mgr, 15778.
06-13 14:02:07.841+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17114057
06-13 14:02:07.952+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17114167
06-13 14:02:08.212+0900 I/UXT     (16123): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:02:08.262+0900 E/TBM     (16123): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:02:08.262+0900 I/MALI    (16123): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=16123   open drm_fd=30 
06-13 14:02:08.382+0900 E/EFL     (16123): edje<16123> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:08.382+0900 E/EFL     (16123): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:08.392+0900 E/EFL     (16123): edje<16123> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:08.392+0900 E/EFL     (16123): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:08.392+0900 E/EFL     (16123): edje<16123> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-13 14:02:08.392+0900 E/EFL     (16123): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 14:02:08.963+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17115172
06-13 14:02:09.053+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17115260
06-13 14:02:09.373+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17115585
06-13 14:02:09.463+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17115673
06-13 14:02:09.723+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17115937
06-13 14:02:09.793+0900 E/EFL     (15778): ecore_x<15778> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17116003
06-13 14:02:10.104+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:02:10.104+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:02:10.104+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(15778)
06-13 14:02:10.104+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 15778, appid: com.samsung.task-mgr, status: bg
06-13 14:02:10.104+0900 I/CAPI_APPFW_APPLICATION(15778): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:02:10.104+0900 W/TASK_MGR_LITE(15778): task-mgr-lite.c: _pause_app(406) > 
06-13 14:02:10.104+0900 I/CAPI_APPFW_APPLICATION(15778): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
06-13 14:02:10.114+0900 E/TASK_MGR_LITE(15778): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
06-13 14:02:10.124+0900 E/TASK_MGR_LITE(15778): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
06-13 14:02:10.124+0900 E/APP_CORE(15778): appcore.c: appcore_flush_memory(793) > Appcore not initialized
06-13 14:02:10.134+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:02:10.134+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:02:10.134+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:02:10.134+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:02:10.134+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:02:10.134+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:02:10.164+0900 I/MALI    (15778): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=15778   close drm_fd=30 
06-13 14:02:10.164+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:02:10.204+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:02:10.204+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:02:10.204+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:02:10.204+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:02:10.234+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:02:10.234+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:02:10.234+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:02:10.254+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:02:10.264+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:02:10.264+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:02:10.264+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:10.264+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:10.264+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:10.284+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:02:10.284+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:02:10.284+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:02:10.284+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:02:10.284+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:02:10.284+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:02:10.374+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:02:10.374+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:02:10.424+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 15778 pgid = 15778
06-13 14:02:10.424+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(15778)
06-13 14:02:10.474+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:02:10.474+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:02:10.474+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:02:10.474+0900 I/Tizen::App( 1175): (243) > App[com.samsung.task-mgr] pid[15778] terminate event is forwarded
06-13 14:02:10.474+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:02:10.474+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.task-mgr, 15778, ]
06-13 14:02:10.474+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:02:10.474+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.task-mgr)
06-13 14:02:10.474+0900 I/Tizen::App( 1175): (512) > Not registered pid(15778)
06-13 14:02:10.474+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.task-mgr]
06-13 14:02:10.474+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:02:10.474+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15778
06-13 14:02:10.474+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15778
06-13 14:02:10.474+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 15778
06-13 14:02:10.484+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1623
06-13 14:02:10.494+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:02:10.504+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.task-mgr, 15778.
06-13 14:02:10.584+0900 W/CRASH_MANAGER(16018): worker.c: worker_job(1199) > 0416055636c69149733012
